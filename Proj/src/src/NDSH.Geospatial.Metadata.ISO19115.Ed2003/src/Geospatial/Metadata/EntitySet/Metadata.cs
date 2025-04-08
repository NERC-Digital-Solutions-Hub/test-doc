
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.EntitySet {

  public abstract class Metadata : MetadataObject {

    private DateTime _dateTimeDownloaded;

    public DateTime DateTimeDownloaded {
      get => _dateTimeDownloaded;
      set => _ = SetProperty(ref _dateTimeDownloaded, value);
    }

    private DateTime _dateTimeUpdated;

    public DateTime DateTimeUpdated {
      get => _dateTimeUpdated;
      set => _ = SetProperty(ref _dateTimeUpdated, value);
    }

    private short _versionNumber;

    public short VersionNumber {
      get => _versionNumber;
      set => _ = SetProperty(ref _versionNumber, value);
    }

    private int _hashCode;

    public int HashCode {
      get => _hashCode;
      set => _ = SetProperty(ref _hashCode, value);
    }

  }

}
