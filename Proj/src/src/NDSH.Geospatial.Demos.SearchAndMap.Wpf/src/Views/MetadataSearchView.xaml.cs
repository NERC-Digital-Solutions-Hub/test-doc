
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Binders;
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

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Views {

  /// <summary>
  /// The metadata serch view of the application.
  /// </summary>
  public partial class MetadataSearchView : UserControl {

    #region Constructors - Destructors
    
    /// <summary>
    /// Initializes the <see cref="MetadataSearchView"/>.
    /// </summary>
    public MetadataSearchView() {
      InitializeComponent();
      InitializeView();
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView() {
      MetadataSearchBinder metadataSearchBinder = (MetadataSearchBinder)AppEngine.Instance.Catalogue.Binders[nameof(MetadataSearchBinder)];
      this.DataContext = metadataSearchBinder;
      //metadataSearchBinder.ShellView = this;
    }

    #endregion
    
  }

}
