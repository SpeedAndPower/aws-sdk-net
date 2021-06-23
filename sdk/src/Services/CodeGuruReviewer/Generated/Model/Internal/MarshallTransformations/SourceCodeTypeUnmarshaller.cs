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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruReviewer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceCodeType Object
    /// </summary>  
    public class SourceCodeTypeUnmarshaller : IUnmarshaller<SourceCodeType, XmlUnmarshallerContext>, IUnmarshaller<SourceCodeType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceCodeType IUnmarshaller<SourceCodeType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceCodeType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceCodeType unmarshalledObject = new SourceCodeType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BranchDiff", targetDepth))
                {
                    var unmarshaller = BranchDiffSourceCodeTypeUnmarshaller.Instance;
                    unmarshalledObject.BranchDiff = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CommitDiff", targetDepth))
                {
                    var unmarshaller = CommitDiffSourceCodeTypeUnmarshaller.Instance;
                    unmarshalledObject.CommitDiff = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RepositoryHead", targetDepth))
                {
                    var unmarshaller = RepositoryHeadSourceCodeTypeUnmarshaller.Instance;
                    unmarshalledObject.RepositoryHead = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestMetadata", targetDepth))
                {
                    var unmarshaller = RequestMetadataUnmarshaller.Instance;
                    unmarshalledObject.RequestMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BucketRepository", targetDepth))
                {
                    var unmarshaller = S3BucketRepositoryUnmarshaller.Instance;
                    unmarshalledObject.S3BucketRepository = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceCodeTypeUnmarshaller _instance = new SourceCodeTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceCodeTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}