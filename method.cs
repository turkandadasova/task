namespace ConsoleApp19
{
    internal class Program
    {

        //InsertArray metodu yaradılır. Metod parametr olaraq int tipindən massiv və params olaraq int-lər qəbul edir.
        //Paramslardan gələn dəyərləri həmin arraya əlavə və sonda dəyişdirilmiş hal köhnə arraya bərabər olsun.
        //(Array resize istifade etmirsiz ozunuz Custom yazirsiz)
        static void Main()
        {
            int[] Array = { 1, 2, 3 };
            Console.WriteLine("kohne array: " + Array);

          
            
            int[] NewArray = { 4, 5, 6 };

            Console.WriteLine("deyisdirilmis array: " + Array);
        }

        static void InsertArray( int[] Array, params int[] Array1)
        {

            int[] NewArray = new int[4];
            Array = NewArray;
        }
        //kod islemir :(
    }
}