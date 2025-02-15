/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.UpdateStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationSettings())
                {
                    context.Writer.WritePropertyName("ApplicationSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApplicationSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAttributesToDelete())
                {
                    context.Writer.WritePropertyName("AttributesToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                    {
                            context.Writer.Write(publicRequestAttributesToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeleteStorageConnectors())
                {
                    context.Writer.WritePropertyName("DeleteStorageConnectors");
                    context.Writer.Write(publicRequest.DeleteStorageConnectors);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetFeedbackURL())
                {
                    context.Writer.WritePropertyName("FeedbackURL");
                    context.Writer.Write(publicRequest.FeedbackURL);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRedirectURL())
                {
                    context.Writer.WritePropertyName("RedirectURL");
                    context.Writer.Write(publicRequest.RedirectURL);
                }

                if(publicRequest.IsSetStorageConnectors())
                {
                    context.Writer.WritePropertyName("StorageConnectors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStorageConnectorsListValue in publicRequest.StorageConnectors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StorageConnectorMarshaller.Instance;
                        marshaller.Marshall(publicRequestStorageConnectorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserSettings())
                {
                    context.Writer.WritePropertyName("UserSettings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserSettingsListValue in publicRequest.UserSettings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UserSettingMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserSettingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateStackRequestMarshaller _instance = new UpdateStackRequestMarshaller();        

        internal static UpdateStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}