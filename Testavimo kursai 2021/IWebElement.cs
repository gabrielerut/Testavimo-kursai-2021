namespace firstInput
{
    internal interface IWebElement
    {
        bool Selected { get; }
        object Text { get; }

        void Click();
    }
}