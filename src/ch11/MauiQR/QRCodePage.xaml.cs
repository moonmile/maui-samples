namespace MauiQR;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

public partial class QRCodePage : ContentPage
{
	public QRCodePage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			cameraBarcodeReaderView.Options = new BarcodeReaderOptions()
			{
				Formats = BarcodeFormat.QrCode
			};
		};
	}

	event Action OnReturn;

	private void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
	{
		var code = e.Results.FirstOrDefault();
		if ( code != null )
		{
			if ( code.Format == BarcodeFormat.QrCode )
			{
                (this.BindingContext as MainViewModel).QRCode = code.Value;

				Dispatcher.Dispatch(async () => {
                    await Navigation.PopAsync();
                });
				return;
            }
		}
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        await Navigation.PopAsync();

    }
}