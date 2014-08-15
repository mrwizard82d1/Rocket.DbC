﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PreConditionException.cs" company="Borderline Studios">
//   Copyright © Borderline Studios. All rights reserved.
// </copyright>
// <summary>
//   Defines the PreConditionException type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Borderline.DbC
{
	[Serializable]
	public class PreConditionException : Exception
	{
		public PreConditionException(string memberName)
			: base(string.Format("Precondition failed for: {0}", memberName))
		{
		}
	}
}