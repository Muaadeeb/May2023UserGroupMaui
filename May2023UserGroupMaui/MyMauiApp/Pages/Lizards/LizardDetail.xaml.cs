using MyMauiApp.Models;

namespace MyMauiApp.Pages.Lizards;

public partial class LizardDetail : ContentPage
{
    public LizardDetail(Lizard lizard)
    {
        InitializeComponent();
        ImgLizard.Source = lizard.ImageName;
        LizardName.Text = lizard.Name;
        LizardSentence.Text = lizard.Sentence;
    }

}