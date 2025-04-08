
#region Imported Namespaces

using NDSH.Database;
using NDSH.Geospatial.Demos.SearchAndMap.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Views {

  /// <summary>
  /// The shell view of the application.
  /// </summary>
  public partial class ShellView : Window, IView {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ShellView"/>.
    /// </summary>
    public ShellView() {
      InitializeComponent();
      InitializeView();
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView() {
      ShellBinder shellBinder = (ShellBinder)AppEngine.Instance.Catalogue.Binders[nameof(ShellBinder)];
      this.DataContext = shellBinder;
      shellBinder.ShellView = this;
    }

    #endregion

    #region Event Procedures

    /// <summary>
    /// Occurs when the left mouse button is pressed on the appliction's caption bar.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="MouseButtonEventArgs"/>.</param>
    private void AppCaptionBar_LeftMouseDown(object sender, MouseButtonEventArgs e) {

      // Make sure the mouse captures the application's caption bar so that the application window can be dragged around.
      this.DragMove();
      
    }

    #endregion
        
  }

}
