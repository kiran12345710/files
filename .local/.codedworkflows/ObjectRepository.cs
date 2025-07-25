using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ACME_SYSTEM.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_ACME_System_1___Log_In
        {
            static string _reference = "DSw1PMK-y0GQ1IKZfxcopA/4llIs0890UmzuUSm_S_qbw";
            public static _Implementation.___Chrome_ACME_System_1___Log_In.__Chrome_ACME_System_1___Log_In Chrome_ACME_System_1___Log_In { get; private set; } = new _Implementation.___Chrome_ACME_System_1___Log_In.__Chrome_ACME_System_1___Log_In();
        }
    }
}

namespace ACME_SYSTEM._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Chrome_ACME_System_1___Log_In
    {
        public class __Chrome_ACME_System_1___Log_In : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_ACME_System_1___Log_In()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "DSw1PMK-y0GQ1IKZfxcopA/s2wAy6PgZU6txMtXGieRTA",
                    DisplayName = "Chrome ACME System 1 - Log In",
                    Screen = this
                };
            }
        }
    }
}