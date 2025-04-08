using dymaptic.GeoBlazor.Core.Components.Views;
using Microsoft.AspNetCore.Components;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Binders;

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Pages {
  public partial class Index
    {
        public readonly double _latitude = 34.027;
        public readonly double _longitude = -118.805;
        
        [Inject] public ShellBinder shellBinder { get; set;}
        [Inject] public MetadataSearchBinder metadataSearchBinder { get; set; }

    
        private async void OnPropertyChangedHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { 
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected override async Task OnInitializedAsync()
        {
            shellBinder.ShellModel.PropertyChanged += OnPropertyChangedHandler;
            metadataSearchBinder.MetadataSearchModel.PropertyChanged += OnPropertyChangedHandler;
            
            await base.OnInitializedAsync();
        }
    }
}