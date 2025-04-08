
#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  public class NilReason2 : ObservableDbEntity, INilReason {

    private string _nilReason;

    public string NilReason {
      get => _nilReason;
      set => _nilReason = value;
    }

  }

  public class IdentifiableObjectUnitTest {

    [Fact]
    public void MD_Format_Type_Test() {

      //MD_Format_Type format = new MD_Format_Type();

      //format.PropertyChanged += Format_PropertyChanged;

      //format.Name = "Koula";
      //format.Version = "2.0";
      //format.Name = "Vasilis";

    }

    private void Format_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e) {
      //Debug.WriteLine($"Format property changed: {e.PropertyName}");
    }

    [Fact]
    public void MD_Resolution_PropertyType_Test() {

      //MD_Resolution_PropertyType resolution = new();

      //List<INilReason> polymorphicPropertyMetadata = new List<INilReason>();

      //NilReason2 nilReason2 = new NilReason2() {
      //  DbId = 1
      //};

      //ReferencedObject reference = new ReferencedObject() {
      //  DbId = 2,
      //  Href = "this is a ref"
      //};

      //polymorphicPropertyMetadata.Add(nilReason2);
      //polymorphicPropertyMetadata.Add(reference);

      //string s = "lala";
    }

  }

}
