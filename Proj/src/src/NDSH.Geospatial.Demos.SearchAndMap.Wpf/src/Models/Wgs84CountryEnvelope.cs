
#region Imported Namespaces

using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UtilityNetworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models {

  /// <summary>
  /// Holds the <see cref="Envelope"/> of a country along its name and ISO 3 code.
  /// </summary>
  public class Wgs84CountryEnvelope {

    private static Dictionary<string, Wgs84CountryEnvelope> _countryEnvelopes;

    #region Public Properties

    /// <summary>
    /// Gets the ISO3 code of the country.
    /// </summary>
    public string Iso3Code {
      get; private set;
    }

    /// <summary>
    /// Gets the name of the country.
    /// </summary>
    public string Name {
      get; private set;
    }

    /// <summary>
    /// Gets the <see cref="Envelope"/> of the country.
    /// </summary>
    public Envelope Envelope {
      get; private set;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Gets the <see cref="Wgs84CountryEnvelope"/> provided an ISO 3 country code.
    /// </summary>
    /// <param name="iso3Code">The <see cref="string"/> with the ISO3 code.</param>
    public static Wgs84CountryEnvelope Create(string iso3Code) {

      if (iso3Code == null) {
        throw new ArgumentNullException(string.Format($"Param {iso3Code} could not be null."));
      }

      if (_countryEnvelopes == null) {
        _countryEnvelopes = GetCountryEnvelopes();
      }

      if (!_countryEnvelopes.ContainsKey(iso3Code)) {
        throw new KeyNotFoundException(string.Format($"Param {iso3Code} not found."));
      }

      return _countryEnvelopes[iso3Code];
      
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static Dictionary<string, Wgs84CountryEnvelope> GetCountryEnvelopes() {

      return new Dictionary<string, Wgs84CountryEnvelope>() {
        { "ABW", new Wgs84CountryEnvelope() { Iso3Code = "ABW", Name = "Aruba", Envelope = new Envelope(-70.2809842, 12.1702998, -69.6409842, 12.8102998, SpatialReferences.Wgs84) } },
        { "AFG", new Wgs84CountryEnvelope() { Iso3Code = "AFG", Name = "Afghanistan", Envelope = new Envelope(60.5176034, 29.3772, 74.889862, 38.4910682, SpatialReferences.Wgs84) } },
        { "AGO", new Wgs84CountryEnvelope() { Iso3Code = "AGO", Name = "Angola", Envelope = new Envelope(11.4609793, -18.038945, 24.0878856, -4.3880634, SpatialReferences.Wgs84) } },
        { "AIA", new Wgs84CountryEnvelope() { Iso3Code = "AIA", Name = "Anguilla", Envelope = new Envelope(-63.6391992, 18.0615454, -62.7125449, 18.7951194, SpatialReferences.Wgs84) } },
        { "ALA", new Wgs84CountryEnvelope() { Iso3Code = "ALA", Name = "Ã…land Islands", Envelope = new Envelope(19.0832098, 59.4541578, 21.3456556, 60.87665, SpatialReferences.Wgs84) } },
        { "ALB", new Wgs84CountryEnvelope() { Iso3Code = "ALB", Name = "Albania", Envelope = new Envelope(-72.6598913, 11.081041, -72.4039128, 11.408791, SpatialReferences.Wgs84) } },
        { "AND", new Wgs84CountryEnvelope() { Iso3Code = "AND", Name = "Andorra", Envelope = new Envelope(1.4135781, 42.4288238, 1.7863837, 42.6559357, SpatialReferences.Wgs84) } },
        { "ANT", new Wgs84CountryEnvelope() { Iso3Code = "ANT", Name = "Netherlands Antilles", Envelope = new Envelope(-68.940593, 12.1544542, -68.9403518, 12.1547472, SpatialReferences.Wgs84) } },
        { "ARE", new Wgs84CountryEnvelope() { Iso3Code = "ARE", Name = "United Arab Emirates", Envelope = new Envelope(51.498, 22.6444, 56.3834, 26.2822, SpatialReferences.Wgs84) } },
        { "ARG", new Wgs84CountryEnvelope() { Iso3Code = "ARG", Name = "Argentina", Envelope = new Envelope(-73.5600329, -55.1850761, -53.6374515, -21.781168, SpatialReferences.Wgs84) } },
        { "ARM", new Wgs84CountryEnvelope() { Iso3Code = "ARM", Name = "Armenia", Envelope = new Envelope(-75.7854388, 4.3951997, -75.6325211, 4.5895768, SpatialReferences.Wgs84) } },
        { "ASM", new Wgs84CountryEnvelope() { Iso3Code = "ASM", Name = "American Samoa", Envelope = new Envelope(-171.2951296, -14.7608358, -167.9322899, -10.8449746, SpatialReferences.Wgs84) } },
        { "ATA", new Wgs84CountryEnvelope() { Iso3Code = "ATA", Name = "Antarctica", Envelope = new Envelope(-180, -85.0511287, 180, -60, SpatialReferences.Wgs84) } },
        { "ATF", new Wgs84CountryEnvelope() { Iso3Code = "ATF", Name = "French Southern Territories", Envelope = new Envelope(39.4138676, -50.2187169, 77.8494974, -11.3139928, SpatialReferences.Wgs84) } },
        { "ATG", new Wgs84CountryEnvelope() { Iso3Code = "ATG", Name = "Antigua and Barbuda", Envelope = new Envelope(-62.5536517, 16.7573901, -61.447857, 17.929, SpatialReferences.Wgs84) } },
        { "AUS", new Wgs84CountryEnvelope() { Iso3Code = "AUS", Name = "Australia", Envelope = new Envelope(72.2460938, -55.3228175, 168.2249543, -9.0882278, SpatialReferences.Wgs84) } },
        { "AUT", new Wgs84CountryEnvelope() { Iso3Code = "AUT", Name = "Austria", Envelope = new Envelope(9.5307487, 46.3722761, 17.160776, 49.0205305, SpatialReferences.Wgs84) } },
        { "AZE", new Wgs84CountryEnvelope() { Iso3Code = "AZE", Name = "Azerbaijan", Envelope = new Envelope(44.7633701, 38.3929551, 51.0090302, 41.9502947, SpatialReferences.Wgs84) } },
        { "BDI", new Wgs84CountryEnvelope() { Iso3Code = "BDI", Name = "Burundi", Envelope = new Envelope(29.0007401, -4.4693155, 30.8498462, -2.3096796, SpatialReferences.Wgs84) } },
        { "BEL", new Wgs84CountryEnvelope() { Iso3Code = "BEL", Name = "Belgium", Envelope = new Envelope(2.3889137, 49.4969821, 6.408097, 51.5516667, SpatialReferences.Wgs84) } },
        { "BEN", new Wgs84CountryEnvelope() { Iso3Code = "BEN", Name = "Benin", Envelope = new Envelope(5.4621058, 6.1730586, 5.7821058, 6.4930586, SpatialReferences.Wgs84) } },
        { "BFA", new Wgs84CountryEnvelope() { Iso3Code = "BFA", Name = "Burkina Faso", Envelope = new Envelope(-5.5132416, 9.4104718, 2.4089717, 15.084, SpatialReferences.Wgs84) } },
        { "BGD", new Wgs84CountryEnvelope() { Iso3Code = "BGD", Name = "Bangladesh", Envelope = new Envelope(88.0075306, 20.3756582, 92.6804979, 26.6382534, SpatialReferences.Wgs84) } },
        { "BGR", new Wgs84CountryEnvelope() { Iso3Code = "BGR", Name = "Bulgaria", Envelope = new Envelope(22.3571459, 41.2353929, 28.8875409, 44.2167064, SpatialReferences.Wgs84) } },
        { "BHR", new Wgs84CountryEnvelope() { Iso3Code = "BHR", Name = "Bahrain", Envelope = new Envelope(72.5273968, 35.1878012, 72.5673968, 35.2278012, SpatialReferences.Wgs84) } },
        { "BHS", new Wgs84CountryEnvelope() { Iso3Code = "BHS", Name = "Bahamas", Envelope = new Envelope(-80.7001941, 20.7059846, -72.4477521, 27.4734551, SpatialReferences.Wgs84) } },
        { "BIH", new Wgs84CountryEnvelope() { Iso3Code = "BIH", Name = "Bosnia and Herzegovina", Envelope = new Envelope(15.7287433, 42.5553114, 19.6237311, 45.2764135, SpatialReferences.Wgs84) } },
        { "BLM", new Wgs84CountryEnvelope() { Iso3Code = "BLM", Name = "Saint BarthÃ©lemy", Envelope = new Envelope(-63.06639, 17.670931, -62.5844019, 18.1375569, SpatialReferences.Wgs84) } },
        { "BLR", new Wgs84CountryEnvelope() { Iso3Code = "BLR", Name = "Belarus", Envelope = new Envelope(23.1783344, 51.2575982, 32.7627809, 56.17218, SpatialReferences.Wgs84) } },
        { "BLZ", new Wgs84CountryEnvelope() { Iso3Code = "BLZ", Name = "Belize", Envelope = new Envelope(-89.2262083, 15.8857286, -87.3098494, 18.496001, SpatialReferences.Wgs84) } },
        { "BMU", new Wgs84CountryEnvelope() { Iso3Code = "BMU", Name = "Bermuda", Envelope = new Envelope(-65.1232222, 32.0469651, -64.4109842, 32.5913693, SpatialReferences.Wgs84) } },
        { "BOL", new Wgs84CountryEnvelope() { Iso3Code = "BOL", Name = "Bolivia", Envelope = new Envelope(-69.6450073, -22.8982742, -57.453, -9.6689438, SpatialReferences.Wgs84) } },
        { "BRA", new Wgs84CountryEnvelope() { Iso3Code = "BRA", Name = "Brazil", Envelope = new Envelope(-73.9830625, -33.8689056, -28.6341164, 5.2842873, SpatialReferences.Wgs84) } },
        { "BRB", new Wgs84CountryEnvelope() { Iso3Code = "BRB", Name = "Barbados", Envelope = new Envelope(-59.8562115, 12.845, -59.2147175, 13.535, SpatialReferences.Wgs84) } },
        { "BRN", new Wgs84CountryEnvelope() { Iso3Code = "BRN", Name = "Brunei Darussalam", Envelope = new Envelope(114.0758734, 4.002508, 115.3635623, 5.1011857, SpatialReferences.Wgs84) } },
        { "BTN", new Wgs84CountryEnvelope() { Iso3Code = "BTN", Name = "Bhutan", Envelope = new Envelope(88.7464724, 26.702016, 92.1252321, 28.246987, SpatialReferences.Wgs84) } },
        { "BVT", new Wgs84CountryEnvelope() { Iso3Code = "BVT", Name = "Bouvet Island", Envelope = new Envelope(2.9345531, -54.654, 3.7791099, -54.187, SpatialReferences.Wgs84) } },
        { "BWA", new Wgs84CountryEnvelope() { Iso3Code = "BWA", Name = "Botswana", Envelope = new Envelope(19.9986474, -26.9059669, 29.375304, -17.778137, SpatialReferences.Wgs84) } },
        { "CAF", new Wgs84CountryEnvelope() { Iso3Code = "CAF", Name = "Central African Republic", Envelope = new Envelope(55.1742999, 25.217277, 55.1762608, 25.2194356, SpatialReferences.Wgs84) } },
        { "CAN", new Wgs84CountryEnvelope() { Iso3Code = "CAN", Name = "Canada", Envelope = new Envelope(-141.00275, 41.6765556, -52.3231981, 83.3362128, SpatialReferences.Wgs84) } },
        { "CCK", new Wgs84CountryEnvelope() { Iso3Code = "CCK", Name = "Cocos (Keeling) Islands", Envelope = new Envelope(96.612524, -12.4055983, 97.1357343, -11.6213132, SpatialReferences.Wgs84) } },
        { "CHE", new Wgs84CountryEnvelope() { Iso3Code = "CHE", Name = "Switzerland", Envelope = new Envelope(5.9559113, 45.817995, 10.4922941, 47.8084648, SpatialReferences.Wgs84) } },
        { "CHL", new Wgs84CountryEnvelope() { Iso3Code = "CHL", Name = "Chile", Envelope = new Envelope(-109.6795789, -56.725, -66.0753474, -17.4983998, SpatialReferences.Wgs84) } },
        { "CHN", new Wgs84CountryEnvelope() { Iso3Code = "CHN", Name = "China", Envelope = new Envelope(-99.4612273, 25.0671341, -98.421576, 25.9161824, SpatialReferences.Wgs84) } },
        { "CIV", new Wgs84CountryEnvelope() { Iso3Code = "CIV", Name = "CÃ´te d'Ivoire", Envelope = new Envelope(-8.601725, 4.1621205, -2.493031, 10.740197, SpatialReferences.Wgs84) } },
        { "CMR", new Wgs84CountryEnvelope() { Iso3Code = "CMR", Name = "Cameroon", Envelope = new Envelope(8.3822176, 1.6546659, 16.1921476, 13.083333, SpatialReferences.Wgs84) } },
        { "COD", new Wgs84CountryEnvelope() { Iso3Code = "COD", Name = "Congo", Envelope = new Envelope(15.2829578, -4.2726671, 15.283136, -4.2723703, SpatialReferences.Wgs84) } },
        { "COG", new Wgs84CountryEnvelope() { Iso3Code = "COG", Name = "Congo", Envelope = new Envelope(11.0048205, -5.149089, 18.643611, 3.713056, SpatialReferences.Wgs84) } },
        { "COK", new Wgs84CountryEnvelope() { Iso3Code = "COK", Name = "Cook Islands", Envelope = new Envelope(-166.0856468, -22.15807, -157.1089329, -8.7168792, SpatialReferences.Wgs84) } },
        { "COL", new Wgs84CountryEnvelope() { Iso3Code = "COL", Name = "Colombia", Envelope = new Envelope(-82.1243666, -4.2316872, -66.8511907, 16.0571269, SpatialReferences.Wgs84) } },
        { "COM", new Wgs84CountryEnvelope() { Iso3Code = "COM", Name = "Comoros", Envelope = new Envelope(43.025305, -12.621, 44.7451922, -11.165, SpatialReferences.Wgs84) } },
        { "CPV", new Wgs84CountryEnvelope() { Iso3Code = "CPV", Name = "Cape Verde", Envelope = new Envelope(-25.3609478, 14.8031546, -22.6673416, 17.2053108, SpatialReferences.Wgs84) } },
        { "CRI", new Wgs84CountryEnvelope() { Iso3Code = "CRI", Name = "Costa Rica", Envelope = new Envelope(-87.2722647, 5.3329698, -82.5060208, 11.2195684, SpatialReferences.Wgs84) } },
        { "CUB", new Wgs84CountryEnvelope() { Iso3Code = "CUB", Name = "Cuba", Envelope = new Envelope(-85.1679702, 19.6275294, -73.9190004, 23.4816972, SpatialReferences.Wgs84) } },
        { "CXR", new Wgs84CountryEnvelope() { Iso3Code = "CXR", Name = "Christmas Island", Envelope = new Envelope(105.5336422, -10.5698515, 105.7130159, -10.4123553, SpatialReferences.Wgs84) } },
        { "CYM", new Wgs84CountryEnvelope() { Iso3Code = "CYM", Name = "Cayman Islands", Envelope = new Envelope(-81.6313748, 19.0620619, -79.5110954, 19.9573759, SpatialReferences.Wgs84) } },
        { "CYP", new Wgs84CountryEnvelope() { Iso3Code = "CYP", Name = "Cyprus", Envelope = new Envelope(25.6451285, 27.4823018, 40.6451285, 42.4823018, SpatialReferences.Wgs84) } },
        { "CZE", new Wgs84CountryEnvelope() { Iso3Code = "CZE", Name = "Czech Republic", Envelope = new Envelope(12.0905901, 48.5518083, 18.859216, 51.0557036, SpatialReferences.Wgs84) } },
        { "DEU", new Wgs84CountryEnvelope() { Iso3Code = "DEU", Name = "Germany", Envelope = new Envelope(5.8663153, 47.2701114, 15.0419319, 55.099161, SpatialReferences.Wgs84) } },
        { "DJI", new Wgs84CountryEnvelope() { Iso3Code = "DJI", Name = "Djibouti", Envelope = new Envelope(41.7713139, 10.9149547, 43.6579046, 12.7923081, SpatialReferences.Wgs84) } },
        { "DMA", new Wgs84CountryEnvelope() { Iso3Code = "DMA", Name = "Dominica", Envelope = new Envelope(-61.6869184, 15.0074207, -61.0329895, 15.7872222, SpatialReferences.Wgs84) } },
        { "DNK", new Wgs84CountryEnvelope() { Iso3Code = "DNK", Name = "Denmark", Envelope = new Envelope(7.7153255, 54.4516667, 15.5530641, 57.9524297, SpatialReferences.Wgs84) } },
        { "DOM", new Wgs84CountryEnvelope() { Iso3Code = "DOM", Name = "Dominican Republic", Envelope = new Envelope(-72.0574706, 17.2701708, -68.1101463, 21.303433, SpatialReferences.Wgs84) } },
        { "DZA", new Wgs84CountryEnvelope() { Iso3Code = "DZA", Name = "Algeria", Envelope = new Envelope(-8.668908, 18.968147, 11.997337, 37.2962055, SpatialReferences.Wgs84) } },
        { "ECU", new Wgs84CountryEnvelope() { Iso3Code = "ECU", Name = "Ecuador", Envelope = new Envelope(-92.2072392, -5.0159314, -75.192504, 1.8835964, SpatialReferences.Wgs84) } },
        { "EGY", new Wgs84CountryEnvelope() { Iso3Code = "EGY", Name = "Egypt", Envelope = new Envelope(24.6499112, 22, 37.1153517, 31.8330854, SpatialReferences.Wgs84) } },
        { "ERI", new Wgs84CountryEnvelope() { Iso3Code = "ERI", Name = "Eritrea", Envelope = new Envelope(55.1720522, 25.2197993, 55.1736716, 25.2220008, SpatialReferences.Wgs84) } },
        { "ESH", new Wgs84CountryEnvelope() { Iso3Code = "ESH", Name = "Western Sahara", Envelope = new Envelope(-13.7867848, 24.1597324, -13.7467848, 24.1997324, SpatialReferences.Wgs84) } },
        { "ESP", new Wgs84CountryEnvelope() { Iso3Code = "ESP", Name = "Spain", Envelope = new Envelope(-18.3936845, 27.4335426, 4.5918885, 43.9933088, SpatialReferences.Wgs84) } },
        { "EST", new Wgs84CountryEnvelope() { Iso3Code = "EST", Name = "Estonia", Envelope = new Envelope(21.3826069, 57.5092997, 28.2100175, 59.9383754, SpatialReferences.Wgs84) } },
        { "ETH", new Wgs84CountryEnvelope() { Iso3Code = "ETH", Name = "Ethiopia", Envelope = new Envelope(32.9975838, 3.397448, 47.9823797, 14.8940537, SpatialReferences.Wgs84) } },
        { "FIN", new Wgs84CountryEnvelope() { Iso3Code = "FIN", Name = "Finland", Envelope = new Envelope(19.0832098, 59.4541578, 31.5867071, 70.0922939, SpatialReferences.Wgs84) } },
        { "FJI", new Wgs84CountryEnvelope() { Iso3Code = "FJI", Name = "Fiji", Envelope = new Envelope(-180, -21.9434274, 180, -12.2613866, SpatialReferences.Wgs84) } },
        { "FLK", new Wgs84CountryEnvelope() { Iso3Code = "FLK", Name = "Falkland Islands (Malvinas)", Envelope = new Envelope(-61.7726772, -53.1186766, -57.3662367, -50.7973007, SpatialReferences.Wgs84) } },
        { "FRA", new Wgs84CountryEnvelope() { Iso3Code = "FRA", Name = "France", Envelope = new Envelope(-5.4534286, 41.2632185, 9.8678344, 51.268318, SpatialReferences.Wgs84) } },
        { "FRO", new Wgs84CountryEnvelope() { Iso3Code = "FRO", Name = "Faroe Islands", Envelope = new Envelope(-7.6882939, 61.3915553, -6.2565525, 62.3942991, SpatialReferences.Wgs84) } },
        { "FSM", new Wgs84CountryEnvelope() { Iso3Code = "FSM", Name = "Micronesia", Envelope = new Envelope(137.2234512, 0.827, 163.2364054, 10.291, SpatialReferences.Wgs84) } },
        { "GAB", new Wgs84CountryEnvelope() { Iso3Code = "GAB", Name = "Gabon", Envelope = new Envelope(8.5002246, -4.1012261, 14.539444, 2.3182171, SpatialReferences.Wgs84) } },
        { "GBR", new Wgs84CountryEnvelope() { Iso3Code = "GBR", Name = "United Kingdom", Envelope = new Envelope(-9.0, 49.75, 2.01, 61.01, SpatialReferences.Wgs84) } },
        { "GEO", new Wgs84CountryEnvelope() { Iso3Code = "GEO", Name = "Georgia", Envelope = new Envelope(-85.6051201, 30.355757, -80.7514321, 35.0013544, SpatialReferences.Wgs84) } },
        { "GGY", new Wgs84CountryEnvelope() { Iso3Code = "GGY", Name = "Guernsey", Envelope = new Envelope(-2.6751703, 49.4155331, -2.501814, 49.5090776, SpatialReferences.Wgs84) } },
        { "GHA", new Wgs84CountryEnvelope() { Iso3Code = "GHA", Name = "Ghana", Envelope = new Envelope(-3.260786, 4.5392525, 1.2732942, 11.1748562, SpatialReferences.Wgs84) } },
        { "GIB", new Wgs84CountryEnvelope() { Iso3Code = "GIB", Name = "Gibraltar", Envelope = new Envelope(-5.3941295, 36.100807, -5.3141295, 36.180807, SpatialReferences.Wgs84) } },
        { "GIN", new Wgs84CountryEnvelope() { Iso3Code = "GIN", Name = "Guinea", Envelope = new Envelope(-77.4591124, 38.1240893, -77.4191124, 38.1640893, SpatialReferences.Wgs84) } },
        { "GLP", new Wgs84CountryEnvelope() { Iso3Code = "GLP", Name = "Guadeloupe", Envelope = new Envelope(-61.809764, 15.8320085, -61.0003663, 16.5144664, SpatialReferences.Wgs84) } },
        { "GMB", new Wgs84CountryEnvelope() { Iso3Code = "GMB", Name = "Gambia", Envelope = new Envelope(-17.0288254, 13.061, -13.797778, 13.8253137, SpatialReferences.Wgs84) } },
        { "GNB", new Wgs84CountryEnvelope() { Iso3Code = "GNB", Name = "Guinea-Bissau", Envelope = new Envelope(-16.894523, 10.6514215, -13.6348777, 12.6862384, SpatialReferences.Wgs84) } },
        { "GNQ", new Wgs84CountryEnvelope() { Iso3Code = "GNQ", Name = "Equatorial Guinea", Envelope = new Envelope(5.4172943, -1.6732196, 11.3598628, 3.989, SpatialReferences.Wgs84) } },
        { "GRC", new Wgs84CountryEnvelope() { Iso3Code = "GRC", Name = "Greece", Envelope = new Envelope(19.2477876, 34.7006096, 29.7296986, 41.7488862, SpatialReferences.Wgs84) } },
        { "GRD", new Wgs84CountryEnvelope() { Iso3Code = "GRD", Name = "Grenada", Envelope = new Envelope(-62.0065868, 11.786, -61.1732143, 12.5966532, SpatialReferences.Wgs84) } },
        { "GRL", new Wgs84CountryEnvelope() { Iso3Code = "GRL", Name = "Greenland", Envelope = new Envelope(-70.907562, 43.0015105, -70.805801, 43.0770931, SpatialReferences.Wgs84) } },
        { "GTM", new Wgs84CountryEnvelope() { Iso3Code = "GTM", Name = "Guatemala", Envelope = new Envelope(-92.3105242, 13.6345804, -88.1755849, 17.8165947, SpatialReferences.Wgs84) } },
        { "GUF", new Wgs84CountryEnvelope() { Iso3Code = "GUF", Name = "French Guiana", Envelope = new Envelope(-54.60278, 2.112222, -51.6346139, 5.7507111, SpatialReferences.Wgs84) } },
        { "GUM", new Wgs84CountryEnvelope() { Iso3Code = "GUM", Name = "Guam", Envelope = new Envelope(144.563426, 13.182335, 145.009167, 13.706179, SpatialReferences.Wgs84) } },
        { "GUY", new Wgs84CountryEnvelope() { Iso3Code = "GUY", Name = "Guyana", Envelope = new Envelope(-61.414905, 1.1710017, -56.4689543, 8.6038842, SpatialReferences.Wgs84) } },
        { "HKG", new Wgs84CountryEnvelope() { Iso3Code = "HKG", Name = "Hong Kong", Envelope = new Envelope(114.0028131, 22.1193278, 114.3228131, 22.4393278, SpatialReferences.Wgs84) } },
        { "HMD", new Wgs84CountryEnvelope() { Iso3Code = "HMD", Name = "Heard Island and McDonald Islands", Envelope = new Envelope(72.2460938, -53.394741, 74.1988754, -52.7030677, SpatialReferences.Wgs84) } },
        { "HND", new Wgs84CountryEnvelope() { Iso3Code = "HND", Name = "Honduras", Envelope = new Envelope(-89.3568207, 12.9808485, -82.1729621, 17.619526, SpatialReferences.Wgs84) } },
        { "HRV", new Wgs84CountryEnvelope() { Iso3Code = "HRV", Name = "Croatia", Envelope = new Envelope(13.2104814, 42.1765993, 19.4470842, 46.555029, SpatialReferences.Wgs84) } },
        { "HTI", new Wgs84CountryEnvelope() { Iso3Code = "HTI", Name = "Haiti", Envelope = new Envelope(-78.1147805, 21.7470269, -78.0747805, 21.7870269, SpatialReferences.Wgs84) } },
        { "HUN", new Wgs84CountryEnvelope() { Iso3Code = "HUN", Name = "Hungary", Envelope = new Envelope(16.1138867, 45.737128, 22.8977094, 48.585257, SpatialReferences.Wgs84) } },
        { "IDN", new Wgs84CountryEnvelope() { Iso3Code = "IDN", Name = "Indonesia", Envelope = new Envelope(94.7717124, -11.2085669, 141.0194444, 6.2744496, SpatialReferences.Wgs84) } },
        { "IMN", new Wgs84CountryEnvelope() { Iso3Code = "IMN", Name = "Isle of Man", Envelope = new Envelope(-4.7946845, 54.0539576, -4.3076853, 54.4178705, SpatialReferences.Wgs84) } },
        { "IND", new Wgs84CountryEnvelope() { Iso3Code = "IND", Name = "India", Envelope = new Envelope(68.1113787, 6.5546079, 97.395561, 35.6745457, SpatialReferences.Wgs84) } },
        { "IOT", new Wgs84CountryEnvelope() { Iso3Code = "IOT", Name = "British Indian Ocean Territory", Envelope = new Envelope(71.036504, -7.6454079, 72.7020157, -5.037066, SpatialReferences.Wgs84) } },
        { "IRL", new Wgs84CountryEnvelope() { Iso3Code = "IRL", Name = "Ireland", Envelope = new Envelope(-11.0133788, 51.222, -5.6582363, 55.636, SpatialReferences.Wgs84) } },
        { "IRN", new Wgs84CountryEnvelope() { Iso3Code = "IRN", Name = "Iran", Envelope = new Envelope(44.0318908, 24.8465103, 63.3332704, 39.7816502, SpatialReferences.Wgs84) } },
        { "IRQ", new Wgs84CountryEnvelope() { Iso3Code = "IRQ", Name = "Iraq", Envelope = new Envelope(38.7936719, 29.0585661, 48.8412702, 37.380932, SpatialReferences.Wgs84) } },
        { "ISL", new Wgs84CountryEnvelope() { Iso3Code = "ISL", Name = "Iceland", Envelope = new Envelope(0.5475318, 51.3863696, 0.5479162, 51.3868275, SpatialReferences.Wgs84) } },
        { "ISR", new Wgs84CountryEnvelope() { Iso3Code = "ISR", Name = "Israel", Envelope = new Envelope(34.2674994, 29.4533796, 35.8950234, 33.3356317, SpatialReferences.Wgs84) } },
        { "ITA", new Wgs84CountryEnvelope() { Iso3Code = "ITA", Name = "Italy", Envelope = new Envelope(6.6272658, 35.2889616, 18.7844746, 47.0921462, SpatialReferences.Wgs84) } },
        { "JAM", new Wgs84CountryEnvelope() { Iso3Code = "JAM", Name = "Jamaica", Envelope = new Envelope(-78.5782366, 16.5899443, -75.7541143, 18.7256394, SpatialReferences.Wgs84) } },
        { "JEY", new Wgs84CountryEnvelope() { Iso3Code = "JEY", Name = "Jersey", Envelope = new Envelope(-2.254512, 49.1625179, -2.0104193, 49.2621288, SpatialReferences.Wgs84) } },
        { "JOR", new Wgs84CountryEnvelope() { Iso3Code = "JOR", Name = "Jordan", Envelope = new Envelope(122.4078085, 10.5378127, 122.6356296, 10.6910595, SpatialReferences.Wgs84) } },
        { "JPN", new Wgs84CountryEnvelope() { Iso3Code = "JPN", Name = "Japan", Envelope = new Envelope(122.7141754, 20.2145811, 154.205541, 45.7112046, SpatialReferences.Wgs84) } },
        { "KAZ", new Wgs84CountryEnvelope() { Iso3Code = "KAZ", Name = "Kazakhstan", Envelope = new Envelope(46.4932179, 40.5686476, 87.3156316, 55.4421701, SpatialReferences.Wgs84) } },
        { "KEN", new Wgs84CountryEnvelope() { Iso3Code = "KEN", Name = "Kenya", Envelope = new Envelope(33.9098987, -4.8995204, 41.899578, 4.62, SpatialReferences.Wgs84) } },
        { "KGZ", new Wgs84CountryEnvelope() { Iso3Code = "KGZ", Name = "Kyrgyzstan", Envelope = new Envelope(69.2649523, 39.1728437, 80.2295793, 43.2667971, SpatialReferences.Wgs84) } },
        { "KHM", new Wgs84CountryEnvelope() { Iso3Code = "KHM", Name = "Cambodia", Envelope = new Envelope(102.3338282, 9.4752639, 107.6276788, 14.6904224, SpatialReferences.Wgs84) } },
        { "KIR", new Wgs84CountryEnvelope() { Iso3Code = "KIR", Name = "Kiribati", Envelope = new Envelope(-179.1645388, -7.0516717, -164.1645388, 7.9483283, SpatialReferences.Wgs84) } },
        { "KNA", new Wgs84CountryEnvelope() { Iso3Code = "KNA", Name = "Saint Kitts and Nevis", Envelope = new Envelope(-63.051129, 16.895, -62.3303519, 17.6158146, SpatialReferences.Wgs84) } },
        { "KOR", new Wgs84CountryEnvelope() { Iso3Code = "KOR", Name = "Korea", Envelope = new Envelope(126.89575, 37.52806, 126.89585, 37.52816, SpatialReferences.Wgs84) } },
        { "KWT", new Wgs84CountryEnvelope() { Iso3Code = "KWT", Name = "Kuwait", Envelope = new Envelope(-72.8801102, -12.0494672, -72.8401102, -12.0094672, SpatialReferences.Wgs84) } },
        { "LAO", new Wgs84CountryEnvelope() { Iso3Code = "LAO", Name = "Lao People's Democratic Republic", Envelope = new Envelope(100.0843247, 13.9096752, 107.6349989, 22.5086717, SpatialReferences.Wgs84) } },
        { "LBN", new Wgs84CountryEnvelope() { Iso3Code = "LBN", Name = "Lebanon", Envelope = new Envelope(-76.4508668, 40.3199193, -76.391965, 40.355802, SpatialReferences.Wgs84) } },
        { "LBR", new Wgs84CountryEnvelope() { Iso3Code = "LBR", Name = "Liberia", Envelope = new Envelope(-11.6080764, 4.1555907, -7.367323, 8.5519861, SpatialReferences.Wgs84) } },
        { "LBY", new Wgs84CountryEnvelope() { Iso3Code = "LBY", Name = "Libyan Arab Jamahiriya", Envelope = new Envelope(9.391081, 19.5008138, 25.3770629, 33.3545898, SpatialReferences.Wgs84) } },
        { "LCA", new Wgs84CountryEnvelope() { Iso3Code = "LCA", Name = "Saint Lucia", Envelope = new Envelope(-61.2853867, 13.508, -60.6669363, 14.2725, SpatialReferences.Wgs84) } },
        { "LIE", new Wgs84CountryEnvelope() { Iso3Code = "LIE", Name = "Liechtenstein", Envelope = new Envelope(9.4716736, 47.0484291, 9.6357143, 47.270581, SpatialReferences.Wgs84) } },
        { "LKA", new Wgs84CountryEnvelope() { Iso3Code = "LKA", Name = "Sri Lanka", Envelope = new Envelope(55.1813071, 25.2287738, 55.1828523, 25.2303051, SpatialReferences.Wgs84) } },
        { "LSO", new Wgs84CountryEnvelope() { Iso3Code = "LSO", Name = "Lesotho", Envelope = new Envelope(27.0114632, -30.6772773, 29.4557099, -28.570615, SpatialReferences.Wgs84) } },
        { "LTU", new Wgs84CountryEnvelope() { Iso3Code = "LTU", Name = "Lithuania", Envelope = new Envelope(20.653783, 53.8967893, 26.8355198, 56.4504213, SpatialReferences.Wgs84) } },
        { "LUX", new Wgs84CountryEnvelope() { Iso3Code = "LUX", Name = "Luxembourg", Envelope = new Envelope(4.9684415, 49.4969821, 6.0344254, 50.430377, SpatialReferences.Wgs84) } },
        { "LVA", new Wgs84CountryEnvelope() { Iso3Code = "LVA", Name = "Latvia", Envelope = new Envelope(20.6715407, 55.6746505, 28.2414904, 58.0855688, SpatialReferences.Wgs84) } },
        { "MAC", new Wgs84CountryEnvelope() { Iso3Code = "MAC", Name = "Macao", Envelope = new Envelope(55.1803834, 25.2349583, 55.1821684, 25.2368385, SpatialReferences.Wgs84) } },
        { "MAF", new Wgs84CountryEnvelope() { Iso3Code = "MAF", Name = "Saint Martin (French part)", Envelope = new Envelope(-63.3605643, 17.8963535, -62.7644063, 18.1902778, SpatialReferences.Wgs84) } },
        { "MAR", new Wgs84CountryEnvelope() { Iso3Code = "MAR", Name = "Morocco", Envelope = new Envelope(-17.2551456, 21.3365321, -0.998429, 36.0505269, SpatialReferences.Wgs84) } },
        { "MCO", new Wgs84CountryEnvelope() { Iso3Code = "MCO", Name = "Monaco", Envelope = new Envelope(7.4090279, 43.7247599, 7.4398704, 43.7519311, SpatialReferences.Wgs84) } },
        { "MDA", new Wgs84CountryEnvelope() { Iso3Code = "MDA", Name = "Moldova", Envelope = new Envelope(29.7521496, 46.6744934, 29.7522496, 46.6745934, SpatialReferences.Wgs84) } },
        { "MDG", new Wgs84CountryEnvelope() { Iso3Code = "MDG", Name = "Madagascar", Envelope = new Envelope(43.2202072, -25.6071002, 50.4862553, -11.9519693, SpatialReferences.Wgs84) } },
        { "MDV", new Wgs84CountryEnvelope() { Iso3Code = "MDV", Name = "Maldives", Envelope = new Envelope(55.1823199, 25.2252959, 55.1837469, 25.2263769, SpatialReferences.Wgs84) } },
        { "MEX", new Wgs84CountryEnvelope() { Iso3Code = "MEX", Name = "Mexico", Envelope = new Envelope(-99.2933416, 19.2726009, -98.9733416, 19.5926009, SpatialReferences.Wgs84) } },
        { "MHL", new Wgs84CountryEnvelope() { Iso3Code = "MHL", Name = "Marshall Islands", Envelope = new Envelope(163.4985095, -0.5481258, 178.4985095, 14.4518742, SpatialReferences.Wgs84) } },
        { "MKD", new Wgs84CountryEnvelope() { Iso3Code = "MKD", Name = "Macedonia", Envelope = new Envelope(20.4529023, 40.8536596, 23.034051, 42.3735359, SpatialReferences.Wgs84) } },
        { "MLI", new Wgs84CountryEnvelope() { Iso3Code = "MLI", Name = "Mali", Envelope = new Envelope(-12.2402835, 10.147811, 4.2673828, 25.001084, SpatialReferences.Wgs84) } },
        { "MLT", new Wgs84CountryEnvelope() { Iso3Code = "MLT", Name = "Malta", Envelope = new Envelope(13.9324226, 35.6029696, 14.8267966, 36.2852706, SpatialReferences.Wgs84) } },
        { "MMR", new Wgs84CountryEnvelope() { Iso3Code = "MMR", Name = "Myanmar", Envelope = new Envelope(92.1719423, 9.4399432, 101.1700796, 28.547835, SpatialReferences.Wgs84) } },
        { "MNE", new Wgs84CountryEnvelope() { Iso3Code = "MNE", Name = "Montenegro", Envelope = new Envelope(-51.662, -29.8446455, -51.3498193, -29.5743342, SpatialReferences.Wgs84) } },
        { "MNG", new Wgs84CountryEnvelope() { Iso3Code = "MNG", Name = "Mongolia", Envelope = new Envelope(87.73762, 41.5800276, 119.931949, 52.1496, SpatialReferences.Wgs84) } },
        { "MNP", new Wgs84CountryEnvelope() { Iso3Code = "MNP", Name = "Northern Mariana Islands", Envelope = new Envelope(144.813338, 14.036565, 146.154418, 20.616556, SpatialReferences.Wgs84) } },
        { "MOZ", new Wgs84CountryEnvelope() { Iso3Code = "MOZ", Name = "Mozambique", Envelope = new Envelope(-96.274167, 19.038889, -96.234167, 19.078889, SpatialReferences.Wgs84) } },
        { "MRT", new Wgs84CountryEnvelope() { Iso3Code = "MRT", Name = "Mauritania", Envelope = new Envelope(55.1665334, 25.2143602, 55.1690669, 25.2163939, SpatialReferences.Wgs84) } },
        { "MSR", new Wgs84CountryEnvelope() { Iso3Code = "MSR", Name = "Montserrat", Envelope = new Envelope(-62.450667, 16.475, -61.9353818, 17.0152978, SpatialReferences.Wgs84) } },
        { "MTQ", new Wgs84CountryEnvelope() { Iso3Code = "MTQ", Name = "Martinique", Envelope = new Envelope(-61.2290815, 14.3948596, -60.8095833, 14.8787029, SpatialReferences.Wgs84) } },
        { "MUS", new Wgs84CountryEnvelope() { Iso3Code = "MUS", Name = "Mauritius", Envelope = new Envelope(56.3825151, -20.725, 63.7151319, -10.138, SpatialReferences.Wgs84) } },
        { "MWI", new Wgs84CountryEnvelope() { Iso3Code = "MWI", Name = "Malawi", Envelope = new Envelope(32.6703616, -17.1296031, 35.9185731, -9.3683261, SpatialReferences.Wgs84) } },
        { "MYS", new Wgs84CountryEnvelope() { Iso3Code = "MYS", Name = "Malaysia", Envelope = new Envelope(105.3471939, -5.1076241, 120.3471939, 9.8923759, SpatialReferences.Wgs84) } },
        { "MYT", new Wgs84CountryEnvelope() { Iso3Code = "MYT", Name = "Mayotte", Envelope = new Envelope(45.0183298, -13.0210119, 45.2999917, -12.6365902, SpatialReferences.Wgs84) } },
        { "NAM", new Wgs84CountryEnvelope() { Iso3Code = "NAM", Name = "Namibia", Envelope = new Envelope(11.5280384, -28.96945, 25.2617671, -16.9634855, SpatialReferences.Wgs84) } },
        { "NCL", new Wgs84CountryEnvelope() { Iso3Code = "NCL", Name = "New Caledonia", Envelope = new Envelope(-92.6876556, 33.0351363, -92.6476556, 33.0751363, SpatialReferences.Wgs84) } },
        { "NER", new Wgs84CountryEnvelope() { Iso3Code = "NER", Name = "Niger", Envelope = new Envelope(0.1689653, 11.693756, 15.996667, 23.517178, SpatialReferences.Wgs84) } },
        { "NFK", new Wgs84CountryEnvelope() { Iso3Code = "NFK", Name = "Norfolk Island", Envelope = new Envelope(167.6873878, -29.333, 168.2249543, -28.796, SpatialReferences.Wgs84) } },
        { "NGA", new Wgs84CountryEnvelope() { Iso3Code = "NGA", Name = "Nigeria", Envelope = new Envelope(2.676932, 4.0690959, 14.678014, 13.885645, SpatialReferences.Wgs84) } },
        { "NIC", new Wgs84CountryEnvelope() { Iso3Code = "NIC", Name = "Nicaragua", Envelope = new Envelope(-87.901532, 10.7076565, -82.6227023, 15.0331183, SpatialReferences.Wgs84) } },
        { "NIU", new Wgs84CountryEnvelope() { Iso3Code = "NIU", Name = "Niue", Envelope = new Envelope(-169.9383436, -19.0840514, -169.9129672, -19.0739661, SpatialReferences.Wgs84) } },
        { "NLD", new Wgs84CountryEnvelope() { Iso3Code = "NLD", Name = "Netherlands", Envelope = new Envelope(-68.6255319, 11.825, 7.2274985, 53.7253321, SpatialReferences.Wgs84) } },
        { "NOR", new Wgs84CountryEnvelope() { Iso3Code = "NOR", Name = "Norway", Envelope = new Envelope(4.0875274, 57.7590052, 31.7614911, 71.3848787, SpatialReferences.Wgs84) } },
        { "NPL", new Wgs84CountryEnvelope() { Iso3Code = "NPL", Name = "Nepal", Envelope = new Envelope(80.0586226, 26.3477581, 88.2015257, 30.446945, SpatialReferences.Wgs84) } },
        { "NRU", new Wgs84CountryEnvelope() { Iso3Code = "NRU", Name = "Nauru", Envelope = new Envelope(166.9091794, -0.5541334, 166.9589235, -0.5025906, SpatialReferences.Wgs84) } },
        { "NZL", new Wgs84CountryEnvelope() { Iso3Code = "NZL", Name = "New Zealand", Envelope = new Envelope(-179.059153, -52.8213687, 179.3643594, -29.0303303, SpatialReferences.Wgs84) } },
        { "OMN", new Wgs84CountryEnvelope() { Iso3Code = "OMN", Name = "Oman", Envelope = new Envelope(55.1759911, 25.2268538, 55.1773672, 25.2291352, SpatialReferences.Wgs84) } },
        { "PAK", new Wgs84CountryEnvelope() { Iso3Code = "PAK", Name = "Pakistan", Envelope = new Envelope(60.872855, 23.5393916, 77.1203914, 37.084107, SpatialReferences.Wgs84) } },
        { "PAN", new Wgs84CountryEnvelope() { Iso3Code = "PAN", Name = "Panama", Envelope = new Envelope(-119.0767707, 35.246906, -119.0367707, 35.286906, SpatialReferences.Wgs84) } },
        { "PCN", new Wgs84CountryEnvelope() { Iso3Code = "PCN", Name = "Pitcairn", Envelope = new Envelope(-130.8049862, -25.1306736, -124.717534, -23.8655769, SpatialReferences.Wgs84) } },
        { "PER", new Wgs84CountryEnvelope() { Iso3Code = "PER", Name = "Peru", Envelope = new Envelope(-89.164781, 41.309511, -89.105652, 41.38197, SpatialReferences.Wgs84) } },
        { "PHL", new Wgs84CountryEnvelope() { Iso3Code = "PHL", Name = "Philippines", Envelope = new Envelope(114.0952145, 4.2158064, 126.8072562, 21.3217806, SpatialReferences.Wgs84) } },
        { "PLW", new Wgs84CountryEnvelope() { Iso3Code = "PLW", Name = "Palau", Envelope = new Envelope(2.9351868, 42.5481153, 2.9840518, 42.5844284, SpatialReferences.Wgs84) } },
        { "PNG", new Wgs84CountryEnvelope() { Iso3Code = "PNG", Name = "Papua New Guinea", Envelope = new Envelope(136.7489081, -13.1816069, 151.7489081, 1.8183931, SpatialReferences.Wgs84) } },
        { "POL", new Wgs84CountryEnvelope() { Iso3Code = "POL", Name = "Poland", Envelope = new Envelope(14.1229707, 49.0020468, 24.145783, 55.0336963, SpatialReferences.Wgs84) } },
        { "PRI", new Wgs84CountryEnvelope() { Iso3Code = "PRI", Name = "Puerto Rico", Envelope = new Envelope(-67.271492, 17.9268695, -65.5897525, 18.5159789, SpatialReferences.Wgs84) } },
        { "PRK", new Wgs84CountryEnvelope() { Iso3Code = "PRK", Name = "Korea", Envelope = new Envelope(124.0913902, 37.5867855, 130.924647, 43.0089642, SpatialReferences.Wgs84) } },
        { "PRT", new Wgs84CountryEnvelope() { Iso3Code = "PRT", Name = "Portugal", Envelope = new Envelope(-31.5575303, 29.8288021, -6.1891593, 42.1543112, SpatialReferences.Wgs84) } },
        { "PRY", new Wgs84CountryEnvelope() { Iso3Code = "PRY", Name = "Paraguay", Envelope = new Envelope(-62.6442036, -27.6063935, -54.258, -19.2876472, SpatialReferences.Wgs84) } },
        { "PSE", new Wgs84CountryEnvelope() { Iso3Code = "PSE", Name = "Palestinian Territory", Envelope = new Envelope(34.0689732, 31.2201289, 35.5739235, 32.5521479, SpatialReferences.Wgs84) } },
        { "PYF", new Wgs84CountryEnvelope() { Iso3Code = "PYF", Name = "French Polynesia", Envelope = new Envelope(-154.9360599, -28.0990232, -134.244799, -7.6592173, SpatialReferences.Wgs84) } },
        { "QAT", new Wgs84CountryEnvelope() { Iso3Code = "QAT", Name = "Qatar", Envelope = new Envelope(55.1726803, 25.2271767, 55.1741485, 25.2289841, SpatialReferences.Wgs84) } },
        { "REU", new Wgs84CountryEnvelope() { Iso3Code = "REU", Name = "RÃ©union", Envelope = new Envelope(55.2164268, -21.3897308, 55.8366924, -20.8717136, SpatialReferences.Wgs84) } },
        { "ROU", new Wgs84CountryEnvelope() { Iso3Code = "ROU", Name = "Romania", Envelope = new Envelope(20.2619773, 43.618682, 30.0454257, 48.2653964, SpatialReferences.Wgs84) } },
        { "RUS", new Wgs84CountryEnvelope() { Iso3Code = "RUS", Name = "Russian Federation", Envelope = new Envelope(19.6389, 41.1850968, 180, 82.0586232, SpatialReferences.Wgs84) } },
        { "RWA", new Wgs84CountryEnvelope() { Iso3Code = "RWA", Name = "Rwanda", Envelope = new Envelope(28.8617546, -2.8389804, 30.8990738, -1.0474083, SpatialReferences.Wgs84) } },
        { "SAU", new Wgs84CountryEnvelope() { Iso3Code = "SAU", Name = "Saudi Arabia", Envelope = new Envelope(121.0177023, 14.4840316, 121.0265441, 14.4846897, SpatialReferences.Wgs84) } },
        { "SDN", new Wgs84CountryEnvelope() { Iso3Code = "SDN", Name = "Sudan", Envelope = new Envelope(6.48, 10.88, 6.52, 10.92, SpatialReferences.Wgs84) } },
        { "SEN", new Wgs84CountryEnvelope() { Iso3Code = "SEN", Name = "Senegal", Envelope = new Envelope(-17.7862419, 12.2372838, -11.3458996, 16.6919712, SpatialReferences.Wgs84) } },
        { "SGP", new Wgs84CountryEnvelope() { Iso3Code = "SGP", Name = "Singapore", Envelope = new Envelope(103.6920359, 1.1304753, 104.0120359, 1.4504753, SpatialReferences.Wgs84) } },
        { "SGS", new Wgs84CountryEnvelope() { Iso3Code = "SGS", Name = "South Georgia and the South Sandwich Islands", Envelope = new Envelope(-42.354739, -59.684, -25.8468303, -53.3500755, SpatialReferences.Wgs84) } },
        { "SHN", new Wgs84CountryEnvelope() { Iso3Code = "SHN", Name = "Saint Helena", Envelope = new Envelope(-5.9973424, -16.23, -5.4234153, -15.704, SpatialReferences.Wgs84) } },
        { "SJM", new Wgs84CountryEnvelope() { Iso3Code = "SJM", Name = "Svalbard and Jan Mayen", Envelope = new Envelope(-9.6848146, 70.6260825, 34.6891253, 81.028076, SpatialReferences.Wgs84) } },
        { "SLB", new Wgs84CountryEnvelope() { Iso3Code = "SLB", Name = "Solomon Islands", Envelope = new Envelope(155.3190556, -13.2424298, 170.3964667, -4.81085, SpatialReferences.Wgs84) } },
        { "SLE", new Wgs84CountryEnvelope() { Iso3Code = "SLE", Name = "Sierra Leone", Envelope = new Envelope(-13.5003389, 6.755, -10.271683, 9.999973, SpatialReferences.Wgs84) } },
        { "SLV", new Wgs84CountryEnvelope() { Iso3Code = "SLV", Name = "El Salvador", Envelope = new Envelope(-90.1790975, 12.976046, -87.6351394, 14.4510488, SpatialReferences.Wgs84) } },
        { "SMR", new Wgs84CountryEnvelope() { Iso3Code = "SMR", Name = "San Marino", Envelope = new Envelope(12.4033246, 43.8937002, 12.5160665, 43.992093, SpatialReferences.Wgs84) } },
        { "SOM", new Wgs84CountryEnvelope() { Iso3Code = "SOM", Name = "Somalia", Envelope = new Envelope(15.246667, -13.200556, 15.286667, -13.160556, SpatialReferences.Wgs84) } },
        { "SPM", new Wgs84CountryEnvelope() { Iso3Code = "SPM", Name = "Saint Pierre and Miquelon", Envelope = new Envelope(-56.6972961, 46.5507173, -55.9033333, 47.365, SpatialReferences.Wgs84) } },
        { "SRB", new Wgs84CountryEnvelope() { Iso3Code = "SRB", Name = "Serbia", Envelope = new Envelope(18.8142875, 42.2322435, 23.006309, 46.1900524, SpatialReferences.Wgs84) } },
        { "STP", new Wgs84CountryEnvelope() { Iso3Code = "STP", Name = "Sao Tome and Principe", Envelope = new Envelope(6.260642, -0.2135137, 7.6704783, 1.9257601, SpatialReferences.Wgs84) } },
        { "SUR", new Wgs84CountryEnvelope() { Iso3Code = "SUR", Name = "Suriname", Envelope = new Envelope(-58.070833, 1.8312802, -53.8433358, 6.225, SpatialReferences.Wgs84) } },
        { "SVK", new Wgs84CountryEnvelope() { Iso3Code = "SVK", Name = "Slovakia", Envelope = new Envelope(16.8331891, 47.7314286, 22.56571, 49.6138162, SpatialReferences.Wgs84) } },
        { "SVN", new Wgs84CountryEnvelope() { Iso3Code = "SVN", Name = "Slovenia", Envelope = new Envelope(13.3754696, 45.4214242, 16.5967702, 46.8766816, SpatialReferences.Wgs84) } },
        { "SWE", new Wgs84CountryEnvelope() { Iso3Code = "SWE", Name = "Sweden", Envelope = new Envelope(10.5930952, 55.1331192, 24.1776819, 69.0599699, SpatialReferences.Wgs84) } },
        { "SWZ", new Wgs84CountryEnvelope() { Iso3Code = "SWZ", Name = "Swaziland", Envelope = new Envelope(55.1807318, 25.2156672, 55.18286, 25.217255, SpatialReferences.Wgs84) } },
        { "SYC", new Wgs84CountryEnvelope() { Iso3Code = "SYC", Name = "Seychelles", Envelope = new Envelope(55.1816849, 25.2237725, 55.184065, 25.2250726, SpatialReferences.Wgs84) } },
        { "SYR", new Wgs84CountryEnvelope() { Iso3Code = "SYR", Name = "Syrian Arab Republic", Envelope = new Envelope(31.5494106, 27.1401861, 46.5494106, 42.1401861, SpatialReferences.Wgs84) } },
        { "TCA", new Wgs84CountryEnvelope() { Iso3Code = "TCA", Name = "Turks and Caicos Islands", Envelope = new Envelope(-72.6799046, 20.9553418, -70.8643591, 22.1630989, SpatialReferences.Wgs84) } },
        { "TCD", new Wgs84CountryEnvelope() { Iso3Code = "TCD", Name = "Chad", Envelope = new Envelope(13.47348, 7.44107, 24, 23.4975, SpatialReferences.Wgs84) } },
        { "TGO", new Wgs84CountryEnvelope() { Iso3Code = "TGO", Name = "Togo", Envelope = new Envelope(-0.1439746, 5.926547, 1.8087605, 11.1395102, SpatialReferences.Wgs84) } },
        { "THA", new Wgs84CountryEnvelope() { Iso3Code = "THA", Name = "Thailand", Envelope = new Envelope(97.3438072, 5.612851, 105.636812, 20.4648337, SpatialReferences.Wgs84) } },
        { "TJK", new Wgs84CountryEnvelope() { Iso3Code = "TJK", Name = "Tajikistan", Envelope = new Envelope(67.3332775, 36.6711153, 75.1539563, 41.0450935, SpatialReferences.Wgs84) } },
        { "TKL", new Wgs84CountryEnvelope() { Iso3Code = "TKL", Name = "Tokelau", Envelope = new Envelope(-172.7213673, -9.6442499, -170.9797586, -8.3328631, SpatialReferences.Wgs84) } },
        { "TKM", new Wgs84CountryEnvelope() { Iso3Code = "TKM", Name = "Turkmenistan", Envelope = new Envelope(52.335076, 35.129093, 66.6895177, 42.7975571, SpatialReferences.Wgs84) } },
        { "TLS", new Wgs84CountryEnvelope() { Iso3Code = "TLS", Name = "Timor-Leste", Envelope = new Envelope(106.9549541, -6.3294157, 106.9551755, -6.3284839, SpatialReferences.Wgs84) } },
        { "TON", new Wgs84CountryEnvelope() { Iso3Code = "TON", Name = "Tonga", Envelope = new Envelope(-179.3866055, -24.1034499, -173.5295458, -15.3655722, SpatialReferences.Wgs84) } },
        { "TTO", new Wgs84CountryEnvelope() { Iso3Code = "TTO", Name = "Trinidad and Tobago", Envelope = new Envelope(-62.083056, 9.8732106, -60.2895848, 11.5628372, SpatialReferences.Wgs84) } },
        { "TUN", new Wgs84CountryEnvelope() { Iso3Code = "TUN", Name = "Tunisia", Envelope = new Envelope(7.5219807, 30.230236, 11.8801133, 37.7612052, SpatialReferences.Wgs84) } },
        { "TUR", new Wgs84CountryEnvelope() { Iso3Code = "TUR", Name = "Turkey", Envelope = new Envelope(25.6212891, 35.8076804, 44.8176638, 42.297, SpatialReferences.Wgs84) } },
        { "TUV", new Wgs84CountryEnvelope() { Iso3Code = "TUV", Name = "Tuvalu", Envelope = new Envelope(-180, -10.9939389, 180, -5.4369611, SpatialReferences.Wgs84) } },
        { "TWN", new Wgs84CountryEnvelope() { Iso3Code = "TWN", Name = "Taiwan", Envelope = new Envelope(6.0296969, 50.8832129, 6.0297969, 50.8833129, SpatialReferences.Wgs84) } },
        { "TZA", new Wgs84CountryEnvelope() { Iso3Code = "TZA", Name = "Tanzania", Envelope = new Envelope(39.2895223, -6.8127308, 39.2897105, -6.812538, SpatialReferences.Wgs84) } },
        { "UGA", new Wgs84CountryEnvelope() { Iso3Code = "UGA", Name = "Uganda", Envelope = new Envelope(29.573433, -1.4823179, 35.000308, 4.2340766, SpatialReferences.Wgs84) } },
        { "UKR", new Wgs84CountryEnvelope() { Iso3Code = "UKR", Name = "Ukraine", Envelope = new Envelope(22.137059, 44.184598, 40.2275801, 52.3791473, SpatialReferences.Wgs84) } },
        { "UMI", new Wgs84CountryEnvelope() { Iso3Code = "UMI", Name = "United States Minor Outlying Islands", Envelope = new Envelope(-162.6816297, 6.1779744, -162.1339885, 6.6514388, SpatialReferences.Wgs84) } },
        { "URY", new Wgs84CountryEnvelope() { Iso3Code = "URY", Name = "Uruguay", Envelope = new Envelope(-58.4948438, -35.7824481, -53.0755833, -30.0853962, SpatialReferences.Wgs84) } },
        { "USA", new Wgs84CountryEnvelope() { Iso3Code = "USA", Name = "United States", Envelope = new Envelope(-125.0011, 24.9493, -66.9326, 49.5904, SpatialReferences.Wgs84) } },
        { "UZB", new Wgs84CountryEnvelope() { Iso3Code = "UZB", Name = "Uzbekistan", Envelope = new Envelope(55.9977865, 37.1821164, 73.1397362, 45.590118, SpatialReferences.Wgs84) } },
        { "VAT", new Wgs84CountryEnvelope() { Iso3Code = "VAT", Name = "Holy See (Vatican City State)", Envelope = new Envelope(12.4457442, 41.9002044, 12.4583653, 41.9073912, SpatialReferences.Wgs84) } },
        { "VCT", new Wgs84CountryEnvelope() { Iso3Code = "VCT", Name = "Saint Vincent and the Grenadines", Envelope = new Envelope(-61.6657471, 12.5166548, -60.9094146, 13.583, SpatialReferences.Wgs84) } },
        { "VEN", new Wgs84CountryEnvelope() { Iso3Code = "VEN", Name = "Venezuela", Envelope = new Envelope(-73.3529632, 0.647529, -59.5427079, 15.9158431, SpatialReferences.Wgs84) } },
        { "VGB", new Wgs84CountryEnvelope() { Iso3Code = "VGB", Name = "Virgin Islands", Envelope = new Envelope(-65.159094, 17.623468, -64.512674, 18.464984, SpatialReferences.Wgs84) } },
        { "VIR", new Wgs84CountryEnvelope() { Iso3Code = "VIR", Name = "Virgin Islands", Envelope = new Envelope(-65.159094, 17.623468, -64.512674, 18.464984, SpatialReferences.Wgs84) } },
        { "VNM", new Wgs84CountryEnvelope() { Iso3Code = "VNM", Name = "Viet Nam", Envelope = new Envelope(102.14441, 8.1790665, 114.3337595, 23.393395, SpatialReferences.Wgs84) } },
        { "VUT", new Wgs84CountryEnvelope() { Iso3Code = "VUT", Name = "Vanuatu", Envelope = new Envelope(166.3355255, -20.4627425, 170.449982, -12.8713777, SpatialReferences.Wgs84) } },
        { "WLF", new Wgs84CountryEnvelope() { Iso3Code = "WLF", Name = "Wallis and Futuna", Envelope = new Envelope(-178.3873749, -14.5630748, -175.9190391, -12.9827961, SpatialReferences.Wgs84) } },
        { "WSM", new Wgs84CountryEnvelope() { Iso3Code = "WSM", Name = "Samoa", Envelope = new Envelope(-124.2064518, 40.7987372, -124.1664518, 40.8387372, SpatialReferences.Wgs84) } },
        { "YEM", new Wgs84CountryEnvelope() { Iso3Code = "YEM", Name = "Yemen", Envelope = new Envelope(41.60825, 11.9084802, 54.7389375, 19, SpatialReferences.Wgs84) } },
        { "ZAF", new Wgs84CountryEnvelope() { Iso3Code = "ZAF", Name = "South Africa", Envelope = new Envelope(16.3335213, -47.1788335, 38.2898954, -22.1250301, SpatialReferences.Wgs84) } },
        { "ZMB", new Wgs84CountryEnvelope() { Iso3Code = "ZMB", Name = "Zambia", Envelope = new Envelope(21.9993509, -18.0765945, 33.701111, -8.2712822, SpatialReferences.Wgs84) } },
        { "ZWE", new Wgs84CountryEnvelope() { Iso3Code = "ZWE", Name = "Zimbabwe", Envelope = new Envelope(25.2373, -22.4241096, 33.0683413, -15.609703, SpatialReferences.Wgs84) } }
      };

    }

    #endregion

  }

}
