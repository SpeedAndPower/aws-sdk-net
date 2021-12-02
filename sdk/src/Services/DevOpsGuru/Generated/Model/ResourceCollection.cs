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
    /// A collection of Amazon Web Services resources supported by DevOps Guru. The two types
    /// of Amazon Web Services resource collections supported are Amazon Web Services CloudFormation
    /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
    /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
    /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
    /// specify up to 500 Amazon Web Services CloudFormation stacks.
    /// </summary>
    public partial class ResourceCollection
    {
        private CloudFormationCollection _cloudFormation;
        private List<TagCollection> _tags = new List<TagCollection>();

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        ///  An array of the names of Amazon Web Services CloudFormation stacks. The stacks define
        /// Amazon Web Services resources that DevOps Guru analyzes. You can specify up to 500
        /// Amazon Web Services CloudFormation stacks. 
        /// </para>
        /// </summary>
        public CloudFormationCollection CloudFormation
        {
            get { return this._cloudFormation; }
            set { this._cloudFormation = value; }
        }

        // Check to see if CloudFormation property is set
        internal bool IsSetCloudFormation()
        {
            return this._cloudFormation != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Amazon Web Services tags that are used by resources in the resource collection.
        /// </para>
        ///  
        /// <para>
        /// Tags help you identify and organize your Amazon Web Services resources. Many Amazon
        /// Web Services services support tagging, so you can assign the same tag to resources
        /// from different services to indicate that the resources are related. For example, you
        /// can assign the same tag to an Amazon DynamoDB table resource that you assign to an
        /// Lambda function. For more information about using tags, see the <a href="https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf">Tagging
        /// best practices</a> whitepaper. 
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Web Services tag has two parts. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A tag <i>key</i> (for example, <code>CostCenter</code>, <code>Environment</code>,
        /// <code>Project</code>, or <code>Secret</code>). Tag <i>keys</i> are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional field known as a tag <i>value</i> (for example, <code>111122223333</code>,
        /// <code>Production</code>, or a team name). Omitting the tag <i>value</i> is the same
        /// as using an empty string. Like tag <i>keys</i>, tag <i>values</i> are case-sensitive.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Together these are known as <i>key</i>-<i>value</i> pairs.
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
        public List<TagCollection> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}