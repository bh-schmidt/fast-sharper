using System;
using System.Collections.Generic;
using System.Text;

namespace FastSharper
{
    public static partial class FS
    {
        const char separator = ',';

        /// <summary>
        /// Converts the <paramref name="src"/> to a csv <see cref="StringBuilder"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="src">The items of the csv.</param>
        /// <param name="mapFields">A function that will map the fields of each line of the csv. The position of the field will correspond to the map order.</param>
        /// <param name="headers">The header of csv.</param>
        /// <exception cref="ArgumentNullException"><paramref name="src"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="mapFields"/> is null.</exception>
        /// <returns></returns>
        public static StringBuilder ToCsv<T>(
            this IEnumerable<T> src,
            Action<T, Action<object>> mapFields,
            string[]? headers = null)
        {
            if (src is null)
                throw new ArgumentNullException(nameof(src));

            if (mapFields is null)
                throw new ArgumentNullException(nameof(mapFields));

            var csvBuilder = new StringBuilder();

            CreateHeader(csvBuilder, headers);
            FillData(csvBuilder, src, mapFields);

            return csvBuilder;
        }

        private static void CreateHeader(StringBuilder csvBuilder, string[]? headers)
        {
            if (headers.IsNull())
                return;

            for (int index = 0; index < headers.Length; index++)
            {
                var header = headers[index];
                AppendField(csvBuilder, header);

                if (index + 1 < headers.Length)
                    csvBuilder.Append(separator);
            }

            csvBuilder.AppendLine();
        }

        private static void FillData<T>(
            StringBuilder csvBuilder,
            IEnumerable<T> collection,
            Action<T, Action<object>> mapFields)
        {
            foreach (var item in collection)
            {
                var lineBuilder = new StringBuilder();
                var map = BuildMap(lineBuilder);
                mapFields(item, map);

                csvBuilder.Append(lineBuilder);
                csvBuilder.AppendLine();
            }
        }

        private static Action<object> BuildMap(StringBuilder lineBuilder) =>
            field =>
            {
                if (lineBuilder.Length != 0)
                    lineBuilder.Append(separator);

                AppendField(lineBuilder, field);
            };

        private static void AppendField(StringBuilder builder, object field)
        {
            builder.Append("\"");

            var fieldBuilder = new StringBuilder()
                .Append(field)
                .Replace("\"", "\"\"");
            
            builder.Append(fieldBuilder);
            builder.Append($"\"");
        }
    }
}
