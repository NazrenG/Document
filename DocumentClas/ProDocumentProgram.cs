
namespace project_2.DocumentClas
{
    internal class ProDocumentProgram:DocumentProgram
    {
      
        public override sealed void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
        
    }
}
