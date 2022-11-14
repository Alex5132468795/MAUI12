namespace MauiApp12;

public partial class MainPage : ContentPage
{
	public int operCost =0;
	public int lorCost=0;
	public MainPage()
	{
		InitializeComponent();
	}
	public void SumCost(int s, int u)
	{
		Cost.Text = "  : " + (s + u).ToString();
	}
	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		operCost = int.Parse((sender as RadioButton).Value.ToString());
		SumCost(operCost, lorCost);
	}
	private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
	{
        lorCost = int.Parse((sender as RadioButton).Value.ToString());
		SumCost(operCost, lorCost);
	}


}

