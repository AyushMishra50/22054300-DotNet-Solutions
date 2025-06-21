namespace FactoryMethodPatternExample
{
    public class PdfFactory : DocumentFactory
    {
        public override IDoc CreateDocument()
        {
            return new PdfDoc();
        }
    }
}
