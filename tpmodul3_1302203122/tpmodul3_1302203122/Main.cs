namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos pos1 = new KodePos() { kelurahan = "Batununggal", kodepos = 40266 };
            KodePos pos2 = new KodePos() { kelurahan = "Kujangsari ", kodepos = 40287 };
            KodePos pos3 = new KodePos() { kelurahan = "Mengger    ", kodepos = 40267 };
            KodePos pos4 = new KodePos() { kelurahan = "Wates      ", kodepos = 40256 };
            KodePos pos5 = new KodePos() { kelurahan = "Cijaura    ", kodepos = 40287 };
            KodePos pos6 = new KodePos() { kelurahan = "Jatisari   ", kodepos = 40286 };
            KodePos pos7 = new KodePos() { kelurahan = "Margasari  ", kodepos = 40286 };
            KodePos pos8 = new KodePos() { kelurahan = "Sekejati   ", kodepos = 40286 };
            KodePos pos9 = new KodePos() { kelurahan = "Kebonwaru  ", kodepos = 40272 };
            KodePos pos10 = new KodePos() { kelurahan = "Maleer     ", kodepos = 40274 };
            KodePos pos11 = new KodePos() { kelurahan = "Samoja     ", kodepos = 40273 };

            Console.WriteLine("Kelurahan" + "    " + "KodePos");
            Console.WriteLine(pos1.kelurahan + "  " + pos1.kodepos);
            Console.WriteLine(pos2.kelurahan + "  " + pos2.kodepos);
            Console.WriteLine(pos3.kelurahan + "  " + pos3.kodepos);
            Console.WriteLine(pos4.kelurahan + "  " + pos4.kodepos);
            Console.WriteLine(pos5.kelurahan + "  " + pos5.kodepos);
            Console.WriteLine(pos6.kelurahan + "  " + pos6.kodepos);
            Console.WriteLine(pos7.kelurahan + "  " + pos7.kodepos);
            Console.WriteLine(pos8.kelurahan + "  " + pos8.kodepos);
            Console.WriteLine(pos9.kelurahan + "  " + pos9.kodepos);
            Console.WriteLine(pos10.kelurahan + "  " + pos10.kodepos);
            Console.WriteLine(pos11.kelurahan + "  " + pos11.kodepos);

            DoorMachine StatusDor = new DoorMachine();
            Console.WriteLine(StatusDor.currentState);

            StatusDor.activeTrigger(DoorMachine.Trigger.KunciPintu);
            StatusDor.activeTrigger(DoorMachine.Trigger.BukaPintu);

        }
    }
}