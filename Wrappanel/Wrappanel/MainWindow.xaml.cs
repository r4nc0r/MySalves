using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wrappanel
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			
			WrapPanel myWrapPanel;
			

			myWrapPanel = new WrapPanel();
			myWrapPanel.Orientation = Orientation.Horizontal;
			myWrapPanel.Width = 400;
			myWrapPanel.Height = 50;
			
			
			
			TextBox txt1 = new TextBox();
			txt1.Width = 100;
			txt1.Height = 50;
			TextBox txt2 = new TextBox();
			txt2.Width = 100;
			txt2.Height = 50;
			TextBox txt3 = new TextBox();
			txt3.Width = 100;
			txt3.Height = 50;
			TextBox txt4 = new TextBox();
			txt4.Width = 100;
			txt4.Height = 50;

			Binding btxt2 = new Binding("Text");
			btxt2.Source = txt1;
			btxt2.Mode = BindingMode.OneWay;
			txt2.SetBinding(TextBox.TextProperty, btxt2);
			Binding btxt3 = new Binding("Text");
			btxt3.Mode = BindingMode.OneWay;
			btxt3.Source = txt2;
			txt3.SetBinding(TextBox.TextProperty, btxt3);
			Binding btxt4 = new Binding("Text");
			btxt4.Mode = BindingMode.OneWay;
			btxt4.Source = txt3;
			txt4.SetBinding(TextBox.TextProperty, btxt4);
			// Add the buttons to the parent WrapPanel using the Children.Add method.
			myWrapPanel.Children.Add(txt1);
			myWrapPanel.Children.Add(txt2);
			myWrapPanel.Children.Add(txt3);
			myWrapPanel.Children.Add(txt4);
			mywindow.AddChild(myWrapPanel);
			
				
		}
	}
}
