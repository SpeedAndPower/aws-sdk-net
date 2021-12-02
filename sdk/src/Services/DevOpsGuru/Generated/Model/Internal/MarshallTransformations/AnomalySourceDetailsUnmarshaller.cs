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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnomalySourceDetails Object
    /// </summary>  
    public class AnomalySourceDetailsUnmarshaller : IUnmarshaller<AnomalySourceDetails, XmlUnmarshallerContext>, IUnmarshaller<AnomalySourceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AnomalySourceDetails IUnmarshaller<AnomalySourceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnomalySourceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AnomalySourceDetails unmarshalledObject = new AnomalySourceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CloudWatchMetricsDetail, CloudWatchMetricsDetailUnmarshaller>(CloudWatchMetricsDetailUnmarshaller.Instance);
                    unmarshalledObject.CloudWatchMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformanceInsightsMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PerformanceInsightsMetricsDetail, PerformanceInsightsMetricsDetailUnmarshaller>(PerformanceInsightsMetricsDetailUnmarshaller.Instance);
                    unmarshalledObject.PerformanceInsightsMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AnomalySourceDetailsUnmarshaller _instance = new AnomalySourceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalySourceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}