using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ChildEducationSoftwareGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IsPlaying(false);
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {

        }
        #region IsPlaying(bool)
        private void IsPlaying(bool bValue)
        {
            btnStop.IsEnabled = bValue;
            btnMoveBackward.IsEnabled = bValue;
            btnMoveForward.IsEnabled = bValue;
            btnPlay.IsEnabled = bValue;
        }
        #endregion

        #region Play and Pause
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            IsPlaying(true);
            if (btnPlay.Content.ToString() == "Play")
            {
                MediaEL.Play();
                btnPlay.Content = "Pause";
            }
            else
            {
                MediaEL.Pause();
                btnPlay.Content = "Play";
            }
        }
        #endregion

        #region Stop
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            MediaEL.Stop();
            btnPlay.Content = "Play";
            IsPlaying(false);
            btnPlay.IsEnabled = true;
        }
        #endregion

        #region Back and Forward
        private void btnMoveForward_Click(object sender, RoutedEventArgs e)
        {
            MediaEL.Position = MediaEL.Position + TimeSpan.FromSeconds(10);
        }

        private void btnMoveBackward_Click(object sender, RoutedEventArgs e)
        {
            MediaEL.Position = MediaEL.Position - TimeSpan.FromSeconds(10);
        }
        #endregion

        #region Open Media
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Filter = "Video (*.wmv)|*.wmv|Audio(*.mp3)|*.mp3";
            if (ofd.ShowDialog() == true)
            {
                MediaEL.Source = new Uri(ofd.FileName);
                btnPlay.IsEnabled = true;
            }
        }
        #endregion

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            drawingPane.Strokes.Clear();
        }
        

       

        private void eraseBtn_Click(object sender, RoutedEventArgs e)
        {
            drawingPane.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboColor.Items.Count > 0 && ((ComboBoxItem)cboColor.SelectedItem).Content != null)
            {
                if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Blue")
                    drawingPane.DefaultDrawingAttributes.Color = Colors.Blue;
                else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Green")
                    drawingPane.DefaultDrawingAttributes.Color = Colors.Green;
                else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Red")
                    drawingPane.DefaultDrawingAttributes.Color = Colors.Red;
                else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Yellow")
                    drawingPane.DefaultDrawingAttributes.Color = Colors.Yellow;
                else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Black")
                    drawingPane.DefaultDrawingAttributes.Color = Colors.Black;
            }

        }

        private void cboBrushSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboBrushSize.Items.Count > 0 && ((ComboBoxItem)cboBrushSize.SelectedItem).Content != null)
            {
                if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "2")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 2;
                    drawingPane.DefaultDrawingAttributes.Height = 2;
                }
                else if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "1")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 1;
                    drawingPane.DefaultDrawingAttributes.Height = 1;
                }
                else if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "4")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 4;
                    drawingPane.DefaultDrawingAttributes.Height = 4;
                }
                else if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "6")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 6;
                    drawingPane.DefaultDrawingAttributes.Height = 6;
                }
                else if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "8")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 8;
                    drawingPane.DefaultDrawingAttributes.Height = 8;
                }
                else if (((ComboBoxItem)cboBrushSize.SelectedItem).Content.ToString() == "10")
                {
                    drawingPane.DefaultDrawingAttributes.Width = 10;
                    drawingPane.DefaultDrawingAttributes.Height = 10;
                }

            }
        }

        private void RadMode_Checked(object sender, RoutedEventArgs e)
        {
            /// Sets the editing mode to Ink or Select.
            
            if (radSelectMode.IsChecked.Value == true)
                drawingPane.EditingMode = InkCanvasEditingMode.Select;
            //else if (radDrawingMode.IsChecked.Value == true)
            //    drawingPane.EditingMode = InkCanvasEditingMode.Ink;
            else if (radEraseMode.IsChecked.Value == true)
            drawingPane.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void RadDrawMode_Checked(object sender, RoutedEventArgs e)
        {
            //drawingPane.EditingMode = InkCanvasEditingMode.Ink;
        }

        //private void RadEraseMode_Checked(object sender, RoutedEventArgs e)
        //{
        //    drawingPane.EditingMode = InkCanvasEditingMode.EraseByPoint;
        //}


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void rushBtn_Click(object sender, RoutedEventArgs e)
        {
            drawingPane.DefaultDrawingAttributes.Color = Colors.Blue;
            drawingPane.DefaultDrawingAttributes.Height = 2;
            drawingPane.DefaultDrawingAttributes.Width = 2;
        }

    }
}
