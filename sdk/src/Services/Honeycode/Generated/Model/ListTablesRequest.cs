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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// Container for the parameters to the ListTables operation.
    /// The ListTables API allows you to retrieve a list of all the tables in a workbook.
    /// </summary>
    public partial class ListTablesRequest : AmazonHoneycodeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in each page of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  This parameter is optional. If a nextToken is not specified, the API returns the
        /// first page of data. 
        /// </para>
        ///  
        /// <para>
        ///  Pagination tokens expire after 1 hour. If you use a token that was returned more
        /// than an hour back, the API will throw ValidationException. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property WorkbookId. 
        /// <para>
        /// The ID of the workbook whose tables are being retrieved.
        /// </para>
        ///  
        /// <para>
        ///  If a workbook with the specified id could not be found, this API throws ResourceNotFoundException.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WorkbookId
        {
            get { return this._workbookId; }
            set { this._workbookId = value; }
        }

        // Check to see if WorkbookId property is set
        internal bool IsSetWorkbookId()
        {
            return this._workbookId != null;
        }

    }
}