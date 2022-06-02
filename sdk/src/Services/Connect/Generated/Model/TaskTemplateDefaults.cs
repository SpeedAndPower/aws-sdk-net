/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Describes default values for fields on a template.
    /// </summary>
    public partial class TaskTemplateDefaults
    {
        private List<TaskTemplateDefaultFieldValue> _defaultFieldValues = new List<TaskTemplateDefaultFieldValue>();

        /// <summary>
        /// Gets and sets the property DefaultFieldValues. 
        /// <para>
        /// Default value for the field.
        /// </para>
        /// </summary>
        public List<TaskTemplateDefaultFieldValue> DefaultFieldValues
        {
            get { return this._defaultFieldValues; }
            set { this._defaultFieldValues = value; }
        }

        // Check to see if DefaultFieldValues property is set
        internal bool IsSetDefaultFieldValues()
        {
            return this._defaultFieldValues != null && this._defaultFieldValues.Count > 0; 
        }

    }
}