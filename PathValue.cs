using System;

namespace CopySrfLoyalty
{
	public class PathValue
	{
		static string TakeValueOfPathVar (string NamePathVar)
		{
			try {
				string pathVarValue = System.Environment.GetEnvironmentVariable(NamePathVar);
				return pathVarValue;
			} catch (Exception ex) {
				 
			}
			return null;
		}
	}
}

