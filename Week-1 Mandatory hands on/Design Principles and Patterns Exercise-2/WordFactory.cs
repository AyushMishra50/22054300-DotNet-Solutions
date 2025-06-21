namespace FactoryMethodPatternExample
{
    public class WordFactory : DocumentFactory
    {
        public override IDoc CreateDocument()
        {
            return new WordDoc();
        }
    }
}
