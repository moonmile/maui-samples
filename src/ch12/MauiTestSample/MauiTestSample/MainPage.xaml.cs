namespace MauiTestSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    Calc _calc = new Calc();


    private void OnCountUpClicked(object sender, EventArgs e)
    {
        _calc.CountUp();
        textCount.Text = $"count is {_calc.Count}";
    }

    private void OnCalcNumberClicked(object sender, EventArgs e)
    {
        int x = int.Parse(textA.Text);
        int y = int.Parse(textB.Text);
        int ans = _calc.Add(x, y);
        textAnswer.Text = ans.ToString();
    }

    private void OnCalcStringClicked(object sender, EventArgs e)
    {
        string ans = _calc.Add(textA.Text, textB.Text);
        textAnswer.Text = ans;
    }
}

