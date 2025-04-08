
# Coordinate ReferenceSystems

| Type                          | Base Type                        | Substitutes                     |
|------------------------------|----------------------------------|----------------------------------|
| AbstractCRSType              | IdentifiedObjectType             | Definition                       |
| AbstractSingleCRS            | AbstractCRSType                  | AbstractCRS                      |
| EngineeringCRSType           | AbstractCRSType                  | AbstractSingleCRS                |
| GeocentricCRSType            | AbstractCRSType                  | AbstractSingleCRS                |
| GeodeticCRSType              | AbstractCRSType                  | AbstractSingleCRS                |
| GeographicCRSType            | AbstractCRSType                  | AbstractSingleCRS                |
| ImageCRSType                 | AbstractCRSType                  | AbstractSingleCRS                |
| TemporalCRSType              | AbstractCRSType                  | AbstractSingleCRS                |
| VerticalCRSType              | AbstractCRSType                  | AbstractSingleCRS                |
| AbstractGeneralDerivedCRSType| AbstractCRSType                  | AbstractSingleCRS                |
| CompoundCRSType              | AbstractCRSType                  | AbstractCRS                      |
| DerivedCRSType               | AbstractGeneralDerivedCRSType    | AbstractGeneralDerivedCRS        |
| ProjectedCRSType             | AbstractGeneralDerivedCRSType    | AbstractGeneralDerivedCRS        |
