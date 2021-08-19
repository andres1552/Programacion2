using System;

namespace Currency_Converter
{
    class Converter_model
    {
        private const double usd = 4031330.00;
        private const double cop = 1049.26;
        private const double pen = 988828.81;
        private byte money = 0;
        private byte type = 0;

        public double getUSD()
        {
            return usd;
        }
        public double getCOP()
        {
            return cop;
        }
        public double getPEN()
        {
            return pen;
        }
        public byte getMoney()
        {
            return money;
        }
        public void setMoney(byte paramMoney)
        {
            money = paramMoney;
        }
        public byte getType()
        {
            return type;
        }
        public void setType(byte paramType)
        {
            type = paramType;
        }
        public double result(byte type, byte money)
        {
            return type == 1 ? money * usd : type == 2 ?
            money * cop : type == 3 ? money * pen : 0;
        }
    }

    class Converter_view
    {
        Converter_model model1 = new Converter_model();
        public void viewBasic()
        {
            Console.WriteLine("1) Dolar -> Bolivares\n");
            Console.WriteLine("Valor actual del dolar: " + model1.getUSD() + "Bs\n");
            Console.WriteLine("2) Peso Colombiano -> Bolivares\n");
            Console.WriteLine("Valor actual del peso colombiano: " + model1.getCOP() + "Bs\n");
            Console.WriteLine("3) Sol Peruano -> Bolivares\n");
            Console.WriteLine("Valor actual del sol peruano: " + model1.getPEN() + "Bs\n");
        }
    }

    class Converter_controler
    {
        static void Main(string[] args)
        {
            byte typeX = 0, moneyX = 0, response = 0;
            double result = 0;
            Converter_view viewObj = new Converter_view();
            Converter_model modelObj = new Converter_model();


            do
            {
                viewObj.viewBasic();
                Console.WriteLine("Indique que conversión desea hacer\n");
                typeX = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("");
                modelObj.setType(typeX);

                Console.WriteLine("¿De cuanto dispone para cambiar?\n");
                moneyX = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("");
                modelObj.setMoney(moneyX);

                Console.WriteLine("Conversión: " 
                + modelObj.result(modelObj.getType(), modelObj.getMoney()));
                Console.WriteLine("");

                Console.WriteLine("¿Desea realizar otra conversión? (1- Si |0- No)");
                response = Convert.ToByte(Console.ReadLine());
                Console.Clear();
            } while (response != 0);

            Console.ReadKey();
        }
    }    
}