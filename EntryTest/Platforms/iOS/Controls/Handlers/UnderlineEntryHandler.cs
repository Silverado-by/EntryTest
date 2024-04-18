using EntryTest.Platforms.iOS.Controls;
using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace EntryTest.Controls.Handlers;
public partial class CustomEntryHandler : ViewHandler<IEntry, IosCustomEntry>
{

    protected override IosCustomEntry CreatePlatformView() => new();
}
