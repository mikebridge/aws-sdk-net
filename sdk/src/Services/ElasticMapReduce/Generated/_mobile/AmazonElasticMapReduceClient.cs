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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.ElasticMapReduce.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Implementation for accessing ElasticMapReduce
    ///
    /// Amazon EMR is a web service that makes it easy to process large amounts of data efficiently.
    /// Amazon EMR uses Hadoop processing combined with several AWS products to do tasks such
    /// as web indexing, data mining, log file analysis, machine learning, scientific simulation,
    /// and data warehousing.
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticMapReduceMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticMapReduceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AmazonElasticMapReduceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials and an
        /// AmazonElasticMapReduceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddInstanceFleet

        internal virtual AddInstanceFleetResponse AddInstanceFleet(AddInstanceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<AddInstanceFleetResponse>(request, options);
        }



        /// <summary>
        /// Adds an instance fleet to a running cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual Task<AddInstanceFleetResponse> AddInstanceFleetAsync(AddInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddInstanceGroups

        internal virtual AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more instance groups to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddJobFlowSteps

        internal virtual AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsResponse>(request, options);
        }



        /// <summary>
        /// AddJobFlowSteps adds new steps to a running cluster. A maximum of 256 steps are allowed
        /// in each job flow.
        /// 
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using SSH to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// For more information on how to do this, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/AddMoreThan256Steps.html">Add
        /// More than 256 Steps to a Cluster</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A step specifies the location of a JAR file stored either on the master node of the
        /// cluster or in Amazon S3. Each step is performed by the main function of the main class
        /// of the JAR file. The main class can be specified either in the manifest of the JAR
        /// or by using the MainFunction parameter of the step.
        /// </para>
        ///  
        /// <para>
        /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
        /// the main function must exit with a zero exit code and all Hadoop jobs started while
        /// the step was running must have completed and run successfully.
        /// </para>
        ///  
        /// <para>
        /// You can only add steps to a cluster that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<AddJobFlowStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in
        /// various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSteps

        internal virtual CancelStepsResponse CancelSteps(CancelStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return Invoke<CancelStepsResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
        /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
        /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
        /// guarantee a step will be canceled, even if the request is successfully submitted.
        /// You can only cancel steps that are in a <code>PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual Task<CancelStepsResponse> CancelStepsAsync(CancelStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityConfiguration

        internal virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a security configuration, which is stored in the service and can be specified
        /// when a cluster is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual Task<CreateSecurityConfigurationResponse> CreateSecurityConfigurationAsync(CreateSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityConfiguration

        internal virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual Task<DeleteSecurityConfigurationResponse> DeleteSecurityConfigurationAsync(DeleteSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }
        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterAsync(new DescribeClusterRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobFlows

        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsResponse>(request, options);
        }


        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        /// instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeJobFlowsAsync(new DescribeJobFlowsRequest(), cancellationToken);
        }



        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        /// instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityConfiguration

        internal virtual DescribeSecurityConfigurationResponse DescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Provides the details of a security configuration by returning the configuration JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual Task<DescribeSecurityConfigurationResponse> DescribeSecurityConfigurationAsync(DescribeSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStep

        internal virtual DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }
        internal virtual DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepResponse>(request, options);
        }


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStepAsync(new DescribeStepRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStepResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBootstrapActions

        internal virtual ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }
        internal virtual ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsResponse>(request, options);
        }


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBootstrapActionsAsync(new ListBootstrapActionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBootstrapActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }
        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }


        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status. This call returns a maximum of 50 clusters per
        /// call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListClustersAsync(new ListClustersRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status. This call returns a maximum of 50 clusters per
        /// call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceFleets

        internal virtual ListInstanceFleetsResponse ListInstanceFleets(ListInstanceFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceFleetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all available details about the instance fleets in a cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceFleets service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual Task<ListInstanceFleetsResponse> ListInstanceFleetsAsync(ListInstanceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceGroups

        internal virtual ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }
        internal virtual ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsResponse>(request, options);
        }


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstanceGroupsAsync(new ListInstanceGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }
        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }


        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstancesAsync(new ListInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityConfigurations

        internal virtual ListSecurityConfigurationsResponse ListSecurityConfigurations(ListSecurityConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the security configurations visible to this account, providing their creation
        /// dates and times, and their names. This call returns a maximum of 50 clusters per call,
        /// but returns a marker to track the paging of the cluster list across multiple ListSecurityConfigurations
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityConfigurations service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual Task<ListSecurityConfigurationsResponse> ListSecurityConfigurationsAsync(ListSecurityConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSteps

        internal virtual ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }
        internal virtual ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsResponse>(request, options);
        }


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify stepIds
        /// with the request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStepsAsync(new ListStepsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify stepIds
        /// with the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceFleet

        internal virtual ModifyInstanceFleetResponse ModifyInstanceFleet(ModifyInstanceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceFleetResponse>(request, options);
        }



        /// <summary>
        /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
        /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
        /// either succeeds or fails atomically.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual Task<ModifyInstanceFleetResponse> ModifyInstanceFleetAsync(ModifyInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceGroups

        internal virtual ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsResponse>(request, options);
        }



        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance group. The input parameters include the new target instance count for the
        /// group and the instance group ID. The call will either succeed or fail atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAutoScalingPolicy

        internal virtual PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates an automatic scaling policy for a core instance group or task instance
        /// group in an Amazon EMR cluster. The automatic scaling policy defines how an instance
        /// group dynamically adds and terminates EC2 instances in response to the value of a
        /// CloudWatch metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyAsync(PutAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutAutoScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAutoScalingPolicy

        internal virtual RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Removes an automatic scaling policy from a specified instance group within an EMR
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyAsync(RemoveAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAutoScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters
        /// in various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>. 
        /// 
        ///  
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunJobFlow

        internal virtual RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowResponse>(request, options);
        }



        /// <summary>
        /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
        /// steps specified. After the steps complete, the cluster stops and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
        /// parameter is set to <code>TRUE</code>, the cluster transitions to the WAITING state
        /// rather than shutting down after the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
        /// parameter to <code>TRUE</code> to lock the cluster and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// For more information on how to do this, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/AddMoreThan256Steps.html">Add
        /// More than 256 Steps to a Cluster</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For long running clusters, we recommend that you periodically store your results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleets configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
        /// parameters or InstanceGroups parameters, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return InvokeAsync<RunJobFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTerminationProtection

        internal virtual SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionResponse>(request, options);
        }



        /// <summary>
        /// SetTerminationProtection locks a cluster (job flow) so the EC2 instances in the cluster
        /// cannot be terminated by user intervention, an API call, or in the event of a job-flow
        /// error. The cluster still terminates upon successful completion of the job flow. Calling
        /// <code>SetTerminationProtection</code> on a cluster is similar to calling the Amazon
        /// EC2 <code>DisableAPITermination</code> API on all EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  <code>SetTerminationProtection</code> is used to prevent accidental termination of
        /// a cluster and to ensure that in the event of an error, the instances persist so that
        /// you can recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a cluster that has been locked by setting <code>SetTerminationProtection</code>
        /// to <code>true</code>, you must first unlock the job flow by a subsequent call to <code>SetTerminationProtection</code>
        /// in which you set the value to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see<a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<SetTerminationProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetVisibleToAllUsers

        internal virtual SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersResponse>(request, options);
        }



        /// <summary>
        /// Sets whether all AWS Identity and Access Management (IAM) users under your account
        /// can access the specified clusters (job flows). This action works on running clusters.
        /// You can also set the visibility of a cluster when you launch it using the <code>VisibleToAllUsers</code>
        /// parameter of <a>RunJobFlow</a>. The SetVisibleToAllUsers action can be called only
        /// by an IAM user who created the cluster or the AWS account that owns the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SetVisibleToAllUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateJobFlows

        internal virtual TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsResponse>(request, options);
        }



        /// <summary>
        /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
        /// down, any step not yet completed is canceled and the EC2 instances on which the cluster
        /// is running are stopped. Any log files not already saved are uploaded to Amazon S3
        /// if a LogUri was specified when the cluster was created.
        /// 
        ///  
        /// <para>
        /// The maximum number of clusters allowed is 10. The call to <code>TerminateJobFlows</code>
        /// is asynchronous. Depending on the configuration of the cluster, it may take up to
        /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
        /// such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateJobFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}