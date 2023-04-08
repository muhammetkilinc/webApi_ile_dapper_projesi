using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ExtensionsTool
    {

        #region IsNull

        /// <summary>
        /// Sınıf yada liste null ise true döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this T item) where T : class => item is null;

        /// <summary>
        /// integer null ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull(this int? item) => item is null;

        /// <summary>
        /// short null ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull(this short? item) => item is null;

        /// <summary>
        /// bool null ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull(this bool? item) => item is null;

        /// <summary>
        /// decimal null ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull(this decimal? item) => item is null;

        /// <summary>
        /// DateTime null ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNull(this DateTime? item) => item is null;

        #endregion


        #region IsNotNull

        /// <summary>
        /// Sınıf yada liste null değil ise true döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull<T>(this T item) where T : class => item is not null;

        /// <summary>
        /// integer null değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull(this int? item) => item is not null;



        /// <summary>
        /// short null değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull(this short? item) => item is not null;


        /// <summary>
        /// bool null değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull(this bool? item) => item is not null;

        /// <summary>
        /// decimal null değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull(this decimal? item) => item is not null;

        /// <summary>
        /// DateTime null değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotNull(this DateTime? item) => item is not null;

        #endregion

        #region IsDefault

        /// <summary>
        /// integer '0' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this int item) => item is default(int);

        /// <summary>
        /// integer '0' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this int? item) => item is default(int);

        /// <summary>
        /// string ifade boş ise yada 'string' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this string item) => item is default(string) || item is "string";

        /// <summary>
        /// decimal '0.0' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this decimal item) => item is default(decimal);

        /// <summary>
        /// decimal '0.0' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this decimal? item) => item is default(decimal);

        /// <summary>
        /// DateTime '01/01/0001 00:00:00' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this DateTime item) => item == default;

        /// <summary>
        /// DateTime '01/01/0001 00:00:00' ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsDefault(this DateTime? item) => item == default(DateTime);

        #endregion


        #region IsNotNull

        /// <summary>
        /// integer '0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this int item) => item is not default(int);

        /// <summary>
        /// integer '0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this int? item) => item is not default(int);

        /// <summary>
        /// integer '0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this short item) => item is not default(short);

        /// <summary>
        /// integer '0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this short? item) => item is not default(short);

        /// <summary>
        /// string ifade boş değil ise ve 'string' eşit değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this string item) => item is not default(string) && item is not "string";

        /// <summary>
        /// List<string> ifade boş değil ise ve 'string' eşit değil ise true döner.
        /// </summary>
        /// <param name="List<string> items"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this List<string> items) => items.FirstOrDefault() is not default(string) && items.FirstOrDefault() is not "string";

        /// <summary>
        /// decimal '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this decimal item) => item is not default(decimal);


        /// <summary>
        /// float '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this float item) => item is not default(float);

        /// <summary>
        /// float '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this float? item) => item is not default(float);
        /// <summary>
        /// double '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this double? item) => item is not default(double);



        /// <summary>
        /// double '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this double item) => item is not default(double);

        /// <summary>
        /// decimal '0.0' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this decimal? item) => item is not default(decimal);

        /// <summary>
        /// DateTime '01/01/0001 00:00:00' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this DateTime item) => item != default;

        /// <summary>
        /// DateTime '01/01/0001 00:00:00' değil ise true döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotDefault(this DateTime? item) => item != default(DateTime);

        #endregion

        /// <summary>
        /// Liste eleman içermiyorsa true döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool NotAny<T>(this IEnumerable<T> items) => !items.Any();


        /// <summary>
        /// Liste null değil ve eleman içeriyorsa true döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool IsNotNullAndAny<T>(this IEnumerable<T> items) => items is not null && items.Any();

        /// <summary>
        /// integer listesi eleman sayısı 1 ve liste elemanlarında '0' içermiyorsa true döner.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool IsCountOneAndNotZero(this IEnumerable<int> items) => items.Count() == 1 && items.Any(a => a is not default(int));



        /// <summary>
        /// Liste null veya eleman içermiyorsa true döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool IsNullOrNotAny<T>(this IEnumerable<T> items) => items is null || items.NotAny();

        /// <summary>
        /// Tarih değerini 'yyyy-MM-dd' formatında string ifade olarak döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ToDateTimeDate(this DateTime item) => item.ToString("yyyy-MM-dd");

        /// <summary>
        /// Tarih değerini 'yyyy-MM-dd' formatında string ifade olarak döner.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ToDateTimeDate(this DateTime? item) => item?.ToString("yyyy-MM-dd");

        /// <summary>
        /// Parametre alınan int listesi değerlerine string join ',' işlemi uygulanır, geriye string ifade döner.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string ToJoinVirgule(this IEnumerable<int> items) => string.Join(",", items);
    }
}
