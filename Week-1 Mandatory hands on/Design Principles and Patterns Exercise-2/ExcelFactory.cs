namespace FactoryMethodPatternExample
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDoc CreateDocument()
        {
            return new ExcelDoc();
        }
    }
}
