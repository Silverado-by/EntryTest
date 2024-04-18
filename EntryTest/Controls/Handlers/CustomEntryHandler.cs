using Microsoft.Maui.Handlers;
#if __IOS__ 
using PlatformView = EntryTest.Platforms.iOS.Controls.IosCustomEntry;
#else
using PlatformView = System.Object;
#endif

namespace EntryTest.Controls.Handlers;
public partial class CustomEntryHandler : ICustomEntryHandler
{
    public CustomEntryHandler() : base(Mapper)
    {

    }
    public CustomEntryHandler(IPropertyMapper mapper)
        : base(mapper ?? Mapper)
    {
    }

    static CustomEntryHandler()
    {

    }

    public static IPropertyMapper<IEntry, ICustomEntryHandler> Mapper =
        new PropertyMapper<IEntry, ICustomEntryHandler>(ViewHandler.ViewMapper)
        {
            
        };

    public CustomEntry VirtualView { get; }

    PlatformView ICustomEntryHandler.PlatformView => PlatformView;
}

public interface ICustomEntryHandler : IViewHandler
{
    /// <summary>
    /// Maui view
    /// </summary>
    new CustomEntry VirtualView { get; }

    /// <summary>
    /// Platform specific implementation
    /// </summary>
    new PlatformView PlatformView { get; }
}