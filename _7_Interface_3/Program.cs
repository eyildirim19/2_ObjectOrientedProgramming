namespace _7_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExcelFile ex = new ExcelFile();
            ex.Path = "C:\\Raporlarin\\Satis.xlsx";
            ex.Name = "Satis";

            TextFile tx = new TextFile();
            tx.Path = "C:\\Katilar\\bilgiler.txt";
            tx.Name = "bilgiler";

            WordFile wf = new WordFile();
            wf.Path = "C:\\Kitaplar\\donemodevi.docx";
            wf.Name = "donemodevi";

            XmlFile xm = new XmlFile();
            xm.Path = "C:\\Kayitla\\users.xml";
            xm.Name = "users";

            FileOperation operation=new FileOperation();
            operation.Read(ex);
            //operation.ReadText(tx);
            //operation.ReadWord(wf);
            operation.Read(wf);
            operation.Read(tx);
            operation.Read(xm);

            Console.ReadKey();
        }
    }
}