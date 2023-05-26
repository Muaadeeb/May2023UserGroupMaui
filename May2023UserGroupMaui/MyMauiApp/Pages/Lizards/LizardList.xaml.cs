using MyMauiApp.Models;

namespace MyMauiApp.Pages.Lizards;

public partial class LizardList : ContentPage
{
    private readonly List<Lizard> lizards = new List<Lizard>()
    {
        new Lizard(){Name = "John Smith", ImageName = "liz1.jfif", Sentence = "John Smith has a passion for cooking and experimenting with new recipes."},
        new Lizard(){Name = "Emily Johnson", ImageName = "liz2.jfif", Sentence = "Emily Johnson is passionate about painting and creating beautiful works of art."},
        new Lizard(){Name = "Michael Williams", ImageName = "liz3.jfif", Sentence = "Michael Williams finds joy in playing the guitar and writing his own songs."},
        new Lizard(){Name = "Jessica Brown", ImageName = "liz4.jfif", Sentence = "Jessica Brown loves to read books, especially mystery novels, and solve puzzles."},
        new Lizard(){Name = "David Jones", ImageName = "liz5.jfif", Sentence = "David Jones is an avid hiker and enjoys exploring nature trails in his free time."},
        new Lizard(){Name = "Jennifer Davis", ImageName = "liz6.jfif", Sentence = "Jennifer Davis enjoys playing basketball and spending time outdoors with friends."},
        new Lizard(){Name = "William Miller", ImageName = "liz7.png", Sentence = "William Miller is a dedicated gamer and enjoys playing a wide variety of video games."},
        new Lizard(){Name = "Elizabeth Anderson", ImageName = "liz8.png", Sentence = "Elizabeth Anderson finds peace and relaxation in practicing yoga and meditation."},
        new Lizard(){Name = "James Martinez", ImageName = "liz9.png", Sentence = "James Martinez loves to travel and explore different cultures and cuisines."},
        new Lizard(){Name = "Sarah Taylor", ImageName = "liz10.png", Sentence = "Sarah Taylor is an enthusiastic runner and enjoys participating in marathons and races."},
    };

	public LizardList()
	{
		InitializeComponent();
        Lizards.ItemsSource = lizards;
	}

    private void Lizards_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Lizard;
        if (selectedItem == null) return;
        Navigation.PushAsync(new LizardDetail(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }

}