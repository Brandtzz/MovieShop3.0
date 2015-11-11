namespace MovieStoreDAL
{
    public class CurencyConverter
    {
        public static double dollar;
        public static double euro;

      public  CurencyConverter()
      {
          euro = 7.46;
          dollar = 6.93;
      }

        public static double EuroConverter(Movie movie)
        {
            double priceInEruo = euro*movie.Price;
            return priceInEruo;
        }

        public static double DollarConverter(Movie movie)
        {
            double priceInDollar = dollar*movie.Price;
            return priceInDollar;

        }
    }
}