using CommunityToolkit.Mvvm.ComponentModel;
using Plugin.Maui.ScreenBrightness;

namespace LightTable.ModelView;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Background))]
    [NotifyPropertyChangedFor(nameof(Kelvin))]
    private int _wb = 50;

    [ObservableProperty]
    private float _brightness = ScreenBrightness.Default.Brightness;

    partial void OnBrightnessChanged(float value) => ScreenBrightness.Default.Brightness = value;

    public Color Background => WhiteBalance.GetColor(Wb);

    public string Kelvin => $"{WhiteBalance.GetKelvin(Wb)}K";


}
