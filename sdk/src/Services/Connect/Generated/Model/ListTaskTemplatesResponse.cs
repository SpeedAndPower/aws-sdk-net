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
    /// This is the response object from the ListTaskTemplates operation.
    /// </summary>
    public partial class ListTaskTemplatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TaskTemplateMetadata> _taskTemplates = new List<TaskTemplateMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is always returned as a null in the response.
        /// </para>
        ///  </important>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TaskTemplates. 
        /// <para>
        /// Provides details about a list of task templates belonging to an instance.
        /// </para>
        /// </summary>
        public List<TaskTemplateMetadata> TaskTemplates
        {
            get { return this._taskTemplates; }
            set { this._taskTemplates = value; }
        }

        // Check to see if TaskTemplates property is set
        internal bool IsSetTaskTemplates()
        {
            return this._taskTemplates != null && this._taskTemplates.Count > 0; 
        }

    }
}