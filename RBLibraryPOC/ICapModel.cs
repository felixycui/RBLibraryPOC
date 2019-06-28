using System;

public class ICapModel
{
    private IEnumerable<ICapability> capabilities; 

    public ICapModel(IEnumerable<ICapability> capabilities)
	{
        this.capabilities = capabilities;  
	}

    IEnumerable<Function> GetFunctions();

    IEnumerable<Action> GetActions();

    IEnumerable<StructuralProperty> GetStructuralProperties();

    IEnumerable<NavigationProperty> GetNavigationProperties();

 


}
