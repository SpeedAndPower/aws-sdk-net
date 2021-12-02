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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A new collection of Amazon Web Services resources that are defined by an Amazon Web
    /// Services tag or tag <i>key</i>/<i>value</i> pair.
    /// </summary>
    public partial class UpdateTagCollectionFilter
    {
        private string _appBoundaryKey;
        private List<string> _tagValues = new List<string>();

        /// <summary>
        /// Gets and sets the property AppBoundaryKey. 
        /// <para>
        /// An Amazon Web Services tag <i>key</i> that is used to identify the Amazon Web Services
        /// resources that DevOps Guru analyzes. All Amazon Web Services resources in your account
        /// and Region tagged with this <i>key</i> make up your DevOps Guru application and analysis
        /// boundary.
        /// </para>
        ///  <important> 
        /// <para>
        /// The string used for a <i>key</i> in a tag that you use to define your resource coverage
        /// must begin with the prefix <code>Devops-guru-</code>. The tag <i>key</i> might be
        /// <code>Devops-guru-deployment-application</code> or <code>Devops-guru-rds-application</code>.
        /// While <i>keys</i> are case-sensitive, the case of <i>key</i> characters don't matter
        /// to DevOps Guru. For example, DevOps Guru works with a <i>key</i> named <code>devops-guru-rds</code>
        /// and a <i>key</i> named <code>DevOps-Guru-RDS</code>. Possible <i>key</i>/<i>value</i>
        /// pairs in your application might be <code>Devops-Guru-production-application/RDS</code>
        /// or <code>Devops-Guru-production-application/containers</code>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AppBoundaryKey
        {
            get { return this._appBoundaryKey; }
            set { this._appBoundaryKey = value; }
        }

        // Check to see if AppBoundaryKey property is set
        internal bool IsSetAppBoundaryKey()
        {
            return this._appBoundaryKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// The values in an Amazon Web Services tag collection.
        /// </para>
        ///  
        /// <para>
        /// The tag's <i>value</i> is an optional field used to associate a string with the tag
        /// <i>key</i> (for example, <code>111122223333</code>, <code>Production</code>, or a
        /// team name). The <i>key</i> and <i>value</i> are the tag's <i>key</i> pair. Omitting
        /// the tag <i>value</i> is the same as using an empty string. Like tag <i>keys</i>, tag
        /// <i>values</i> are case-sensitive. You can specify a maximum of 256 characters for
        /// a tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && this._tagValues.Count > 0; 
        }

    }
}