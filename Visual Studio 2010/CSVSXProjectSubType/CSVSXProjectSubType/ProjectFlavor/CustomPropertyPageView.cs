﻿/****************************** Module Header ******************************\
 * Module Name:  CustomPropertyPageView.cs
 * Project:      CSVSXProjectSubType
 * Copyright (c) Microsoft Corporation.
 * 
 * The CustomPropertyPageView Class inherits the PageView Class and overrides 
 * the PropertyControlTable Property, to which this class adds two Property 
 * Name / Control KeyValuePairs. For more detailed description, see the 
 * PageView Class.
 * 
 * 
 * This source is subject to the Microsoft Public License.
 * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
 * All other rights reserved.
 * 
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
 * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Runtime.InteropServices;
using CSVSXProjectSubType.PropertyPageBase;


namespace CSVSXProjectSubType.ProjectFlavor
{
	[Guid("2B384DB3-C478-4ff0-B6AF-785A161799CC")]
    partial class CustomPropertyPageView : PageView
	{
        public const string StringPropertyTag = "StringProperty";
        public const string BooleanPropertyTag = "BooleanProperty";

		#region Constructors
		/// <summary>
		/// This is the runtime constructor.
		/// </summary>
		/// <param name="site">Site for the page.</param>
		public CustomPropertyPageView(IPageViewSite site)
			: base(site)
		{
			InitializeComponent();
		}
		/// <summary>
		/// This constructor is only to enable winform designers
		/// </summary>
		public CustomPropertyPageView()
		{
			InitializeComponent();
		}
		#endregion

		private PropertyControlTable propertyControlTable;

        /// <summary>
        /// This property is used to map the control on a PageView object to a property
        /// in PropertyStore object.
        /// 
        /// This property will be called in the base class's constructor, which means that
        /// the InitializeComponent has not been called and the Controls have not been
        /// initialized.
        /// </summary>
		protected override PropertyControlTable PropertyControlTable
		{
			get
			{
				if (propertyControlTable == null)
				{
					// This is the list of properties that will be persisted and their
					// assciation to the controls.
					propertyControlTable = new PropertyControlTable();

                    // This means that this CustomPropertyPageView object has not been
                    // initialized.
                    if (string.IsNullOrEmpty(base.Name))
                    {
                        this.InitializeComponent();
                    }

                    // Add two Property Name / Control KeyValuePairs. 
					propertyControlTable.Add(StringPropertyTag, tbStringProperty);
                    propertyControlTable.Add(BooleanPropertyTag, chkBooleanProperty);
				}
				return propertyControlTable;
			}
		}
	}
}