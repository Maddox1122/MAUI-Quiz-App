

namespace Desktop_089667;

public partial class MainPage : ContentPage
{
    private List<Vragen> vragen;
    private List<Vragen> answeredQuestions;
    private int currentQuestionIndex;
    private Vragen currentQuestion;

    public MainPage()
    {
        InitializeComponent();
        vragen = new List<Vragen>();
        answeredQuestions = new List<Vragen>();
        Vragen vraag1 = new Vragen(1, "Wie is de hoofdrolspeler in de 'God of War' games?", "Zeus", "Kratos", "Ares", "B");
        Vragen vraag2 = new Vragen(2, "In welke mythologie is de wereld van 'God of War' voornamelijk gebaseerd?", "Griekse mythologie", "Noorse mythologie", "Egyptische mythologie", "B");
        Vragen vraag3 = new Vragen(3, "Welk wapen gebruikt Kratos als zijn belangrijkste hulpmiddel in gevechten?", "Zwaard van de Oorlog", "Bliksemschicht van Zeus", "Leviathan Axe", "C");
        Vragen vraag4 = new Vragen(4, "Hoe heet Kratos' zoon in de nieuwere 'God of War' game?", "Atreus", "Deimos", "Calliope", "A");
        Vragen vraag5 = new Vragen(5, "Welke Griekse god wil Kratos wreken in het eerste deel van de 'God of War' serie?", "Hera", "Poseidon", "Ares", "C");

        vragen.Add(vraag1);
        vragen.Add(vraag2);
        vragen.Add(vraag3);
        vragen.Add(vraag4);
        vragen.Add(vraag5);

        currentQuestionIndex = 0;
        LoadQuestion();
        LoadListView();
    }

    private void LoadListView()
    {
        listviewVragen.ItemsSource = null;
        listviewVragen.ItemsSource = answeredQuestions;
    }

    private void LoadQuestion()
    {
        if (currentQuestionIndex >= 0 && currentQuestionIndex < vragen.Count)
        {
            currentQuestion = vragen[currentQuestionIndex];
            vraag.Text = "Vraag " + currentQuestion.Id + ":" + currentQuestion.Vraag;
            optiea.Text = "A " + currentQuestion.AntwoordA;
            optieb.Text = "B " + currentQuestion.AntwoordB;
            optiec.Text = "C " + currentQuestion.AntwoordC;
        }
        else
        {
            vraag.Text = "Geen vragen meer";
            optiea.Text = string.Empty;
            optieb.Text = string.Empty;
            optiec.Text = string.Empty;
        }
    }



    private int score;
    public void Antwoord_Clicked(object sender, EventArgs e)
    {
        string answer = vraaginvoer.Text;
        answer = answer.Trim().ToUpper();

        if (currentQuestion != null && answer == currentQuestion.GoedeAntwoord)
        {
            score++;
            Score.Text = "Score: " + score.ToString();
        }
        if(currentQuestionIndex < 5)
        {
            answeredQuestions.Add(vragen[currentQuestionIndex]);
            currentQuestionIndex++;
            LoadQuestion();
            LoadListView();

            vraaginvoer.Text = "";
        }
    }

    private void reset_Clicked(object sender, EventArgs e)
    {
        currentQuestionIndex = 0;
        LoadQuestion();
        Score.Text = "Score: 0";
        score = 0;
        listviewVragen.ItemsSource = null;
        answeredQuestions.Clear();
    }

}