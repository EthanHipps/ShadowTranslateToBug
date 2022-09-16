namespace ShadowTranslateToBug;

public partial class MainPage : ContentPage
{
    private const ushort CLOSE_MENU_DURATION = 240;
    private const ushort OPEN_MENU_DURATION = 320;
    public bool IsMenuExpanded { get; set; } = false;

    public MainPage()
    {
        InitializeComponent();
    }


    private async void OnActionsMenuButtonClickedAsync(object sender, EventArgs e)
    {
        if (IsMenuExpanded)
        {
            await Task.WhenAll(
                SubAction1.TranslateTo(0, 72, CLOSE_MENU_DURATION,
                    Easing.SinInOut),
                SubAction2.TranslateTo(0, 128, CLOSE_MENU_DURATION,
                    Easing.SinInOut),
                SubAction3.TranslateTo(0, 184, CLOSE_MENU_DURATION,
                    Easing.SinInOut),
                SubAction4.TranslateTo(0, 240, CLOSE_MENU_DURATION,
                    Easing.SinInOut));

            IsMenuExpanded = false;
        }
        else
        {
            IsMenuExpanded = true;

            await Task.WhenAll(
                SubAction1.TranslateTo(0, 0, OPEN_MENU_DURATION, Easing.SinInOut),
                SubAction2.TranslateTo(0, 0, OPEN_MENU_DURATION, Easing.SinInOut),
                SubAction3.TranslateTo(0, 0, OPEN_MENU_DURATION, Easing.SinInOut),
                SubAction4.TranslateTo(0, 0, OPEN_MENU_DURATION, Easing.SinInOut));
        }

        IsMenuExpanded = IsMenuExpanded;
    }
}