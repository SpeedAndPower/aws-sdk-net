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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServiceTemplateVersion operation.
    /// If no other minor versions of a service template exist, delete a major version of
    /// the service template if it's not the <code>Recommended</code> version. Delete the
    /// <code>Recommended</code> version of the service template if no other major versions
    /// or minor versions of the service template exist. A major version of a service template
    /// is a version that <i>isn't</i> backwards compatible.
    /// 
    ///  
    /// <para>
    /// Delete a minor version of a service template if it's not the <code>Recommended</code>
    /// version. Delete a <code>Recommended</code> minor version of the service template if
    /// no other minor versions of the service template exist. A minor version of a service
    /// template is a version that's backwards compatible.
    /// </para>
    /// </summary>
    public partial class DeleteServiceTemplateVersionRequest : AmazonProtonRequest
    {
        private string _majorVersion;
        private string _minorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The service template major version to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string MajorVersion
        {
            get { return this._majorVersion; }
            set { this._majorVersion = value; }
        }

        // Check to see if MajorVersion property is set
        internal bool IsSetMajorVersion()
        {
            return this._majorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// The service template minor version to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string MinorVersion
        {
            get { return this._minorVersion; }
            set { this._minorVersion = value; }
        }

        // Check to see if MinorVersion property is set
        internal bool IsSetMinorVersion()
        {
            return this._minorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}