
# Inheritance

The following are all top level classes used compose concrete types used for the Geographic Metadata representation.

```csharp
public abstract class AbstractObject_Type          : ObservableModel, IObjectIdentification {}

public          class ObjectReference_PropertyType : ObservableModel, IObjectReference {}

public abstract class CodeListValue_Type           : CharacterString, ICodeList, ICodeListValue, ICodeSpace {}
```

## Class Types Rules

The following are rules about how to compose concrete Geographic Metadata Classes.


```csharp
// Objects (inheriting from AbstractObject_Type)
public          class XX_XXX_Type                  : AbstractObject_Type {}

// Codelists (inheriting from CodeListValue_Type)
public          class XX_XXX_CodeList              : CodeListValue_Type {}

// Enum Wrappers (inheriting from NilReasonModel)
public          class XX_XXX_PropertyType          : NilReasonModel {}
```

## Class Type Exceptions

The following are exceptions in the rules described above

```csharp

// Objects inheriting from NilReasonModel instead of AbstractObject_Type
public          class XX_PropertyType              : NilReasonModel {}

// Objects inheriting from ObjectReference_PropertyType instead of AbstractObject_Type
public          class XX_PropertyType              : ObjectReference_PropertyType {}
```
