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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The options for managing connection authorization for new client connections.
    /// </summary>
    public partial class ClientConnectResponseOptions
    {
        private bool? _enabled;
        private string _lambdaFunctionArn;
        private ClientVpnEndpointAttributeStatus _status;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether client connect options are enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function used for connection authorization.
        /// </para>
        /// </summary>
        public string LambdaFunctionArn
        {
            get { return this._lambdaFunctionArn; }
            set { this._lambdaFunctionArn = value; }
        }

        // Check to see if LambdaFunctionArn property is set
        internal bool IsSetLambdaFunctionArn()
        {
            return this._lambdaFunctionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of any updates to the client connect options.
        /// </para>
        /// </summary>
        public ClientVpnEndpointAttributeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}