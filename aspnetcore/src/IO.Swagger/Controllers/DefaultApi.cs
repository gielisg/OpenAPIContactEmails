/*
 * Contact Emails
 *
 * Manages the emails used to contact a Contact.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: gielisg@selectsoftware.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Provides a list of Contact Email Mandatory Types Rules
        /// </summary>
        /// <remarks>List of Contact Email Mandatory Types. </remarks>
        /// <param name="">Id. of the Contact</param>
        /// <response code="200">Successfully returned a list of a Contact Email Usage Mandatory Rules.</response>
        /// <response code="204">Resource not found</response>
        /// <response code="400">Bad input parameter</response>
        /// <response code="401">Session has expired</response>
        /// <response code="403">Authorisation error</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/Selcomm/ContactEmails/1.0.0/ContactEmailMandatoryRules")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ContactEmailMandatoryTypeList")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ContactEmailMandatoryRule>), description: "Successfully returned a list of a Contact Email Usage Mandatory Rules.")]
        [SwaggerResponse(statusCode: 204, type: typeof(Error), description: "Resource not found")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad input parameter")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Session has expired")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Authorisation error")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal server error")]
        public virtual IActionResult ContactEmailMandatoryTypeList([FromQuery][Required()] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContactEmailMandatoryRule>));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204, default(Error));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Type\" : \"Home Email\",\n  \"TypeCode\" : \"HE\"\n}, {\n  \"Type\" : \"Home Email\",\n  \"TypeCode\" : \"HE\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ContactEmailMandatoryRule>>(exampleJson)
                        : default(List<ContactEmailMandatoryRule>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Provides a list of Contact Email Usage items for a Contact
        /// </summary>
        /// <remarks>List of Contact Email Usage. </remarks>
        /// <param name="">Id. of the Contact</param>
        /// <param name="includeTypes">TRUE will include list of available Email Type Codes, FALSE will not.</param>
        /// <param name="includeMandatoryRules">TRUE will include list of Mandatory Email Type Codes, FALSE will not.</param>
        /// <response code="200">Contact Email Usage</response>
        /// <response code="204">Resource not found</response>
        /// <response code="400">Bad input parameter</response>
        /// <response code="401">Session has expired</response>
        /// <response code="403">Authorisation error</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/Selcomm/ContactEmails/1.0.0/ContactEmailUsage")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ContactEmailUsage")]
        [SwaggerResponse(statusCode: 200, type: typeof(ContactEmailUsage), description: "Contact Email Usage")]
        [SwaggerResponse(statusCode: 204, type: typeof(Error), description: "Resource not found")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad input parameter")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Session has expired")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Authorisation error")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal server error")]
        public virtual IActionResult ContactEmailUsage([FromQuery][Required()] , [FromQuery][Required()]bool? includeTypes, [FromQuery][Required()]bool? includeMandatoryRules)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContactEmailUsage));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204, default(Error));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"ContactEmailUsage\" : [ {\n    \"UpdatedBy\" : \"4001304\",\n    \"Id\" : 1,\n    \"LastUpdated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"EmailAddress\" : \"gielisg@selectsoftware.com.au\",\n    \"FromDateTime\" : {\n      \"FromDateTime\" : \"2000-01-23T04:56:07.000+00:00\"\n    },\n    \"EmailTypes\" : [ {\n      \"Code\" : \"HE\",\n      \"Name\" : \"Home Email\"\n    }, {\n      \"Code\" : \"HE\",\n      \"Name\" : \"Home Email\"\n    } ]\n  }, {\n    \"UpdatedBy\" : \"4001304\",\n    \"Id\" : 1,\n    \"LastUpdated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"EmailAddress\" : \"gielisg@selectsoftware.com.au\",\n    \"FromDateTime\" : {\n      \"FromDateTime\" : \"2000-01-23T04:56:07.000+00:00\"\n    },\n    \"EmailTypes\" : [ {\n      \"Code\" : \"HE\",\n      \"Name\" : \"Home Email\"\n    }, {\n      \"Code\" : \"HE\",\n      \"Name\" : \"Home Email\"\n    } ]\n  } ],\n  \"ContactEmailTypes\" : [ null, null ],\n  \"ContactEmailMandatoryRules\" : [ {\n    \"Type\" : \"Home Email\",\n    \"TypeCode\" : \"HE\"\n  }, {\n    \"Type\" : \"Home Email\",\n    \"TypeCode\" : \"HE\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ContactEmailUsage>(exampleJson)
                        : default(ContactEmailUsage);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Provides history of Contact Email Usage items for a Contact
        /// </summary>
        /// <remarks>List of Contact Email Usage. </remarks>
        /// <param name="">The SessionKey for the current Session.</param>
        /// <param name="">Id. of the Contact</param>
        /// <response code="200">Contact Email Usage History</response>
        /// <response code="204">Resource not found</response>
        /// <response code="400">Bad input parameter</response>
        /// <response code="401">Session has expired</response>
        /// <response code="403">Authorisation error</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/Selcomm/ContactEmails/1.0.0/ContactEmailUsageHistory")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ContactEmailUsageHistory")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ContactEmailHistory>), description: "Contact Email Usage History")]
        [SwaggerResponse(statusCode: 204, type: typeof(Error), description: "Resource not found")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad input parameter")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Session has expired")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Authorisation error")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal server error")]
        public virtual IActionResult ContactEmailUsageHistory([FromHeader][Required()] , [FromQuery][Required()] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContactEmailHistory>));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204, default(Error));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "[ {\n  \"LastUpdatedBy\" : \"4001304\",\n  \"EmailType\" : \"Mobile\",\n  \"CreatedBy\" : \"4001304\",\n  \"Id\" : 1,\n  \"ToDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"EmailTypeCode\" : \"HE\",\n  \"EmailAddress\" : \"gielisg@selectsoftware.com.au\",\n  \"FromDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"CreatedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"LastUpdatedDateTime\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"LastUpdatedBy\" : \"4001304\",\n  \"EmailType\" : \"Mobile\",\n  \"CreatedBy\" : \"4001304\",\n  \"Id\" : 1,\n  \"ToDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"EmailTypeCode\" : \"HE\",\n  \"EmailAddress\" : \"gielisg@selectsoftware.com.au\",\n  \"FromDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"CreatedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"LastUpdatedDateTime\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ContactEmailHistory>>(exampleJson)
                        : default(List<ContactEmailHistory>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates Email Usage for a Contact
        /// </summary>
        /// <remarks>Updates Contact Email Usage. </remarks>
        /// <param name="">The SessionKey for the current Session.</param>
        /// <param name="body">Contact Email Usage Update</param>
        /// <response code="200">ContactEmailUsageUpdateResponse</response>
        /// <response code="204">Resource not found</response>
        /// <response code="400">Bad input parameter</response>
        /// <response code="401">Session has expired</response>
        /// <response code="403">Authorisation error</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        [Route("/Selcomm/ContactEmails/1.0.0/ContactEmailUsageUpdate")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ContactEmailUsageUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse200), description: "ContactEmailUsageUpdateResponse")]
        [SwaggerResponse(statusCode: 204, type: typeof(Error), description: "Resource not found")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad input parameter")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Session has expired")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Authorisation error")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal server error")]
        public virtual IActionResult ContactEmailUsageUpdate([FromHeader][Required()] , [FromBody]ContactEmailUsageUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse200));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204, default(Error));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"ErrorMessage\" : \"Missing mandatory Email Type\",\n  \"Successful\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse200>(exampleJson)
                        : default(InlineResponse200);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Provides a list of Contact Phone Types
        /// </summary>
        /// <remarks>List of Contact Email Types to support GUI selection List </remarks>
        /// <response code="200">Successfully returned a list of a Contact Email Types.</response>
        /// <response code="204">Resource not found</response>
        /// <response code="400">Bad input parameter</response>
        /// <response code="401">Session has expired</response>
        /// <response code="403">Authorisation error</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/Selcomm/ContactEmails/1.0.0/ContactEmailTypes")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ContactPhoneTypeList")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ContactEmailType>), description: "Successfully returned a list of a Contact Email Types.")]
        [SwaggerResponse(statusCode: 204, type: typeof(Error), description: "Resource not found")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad input parameter")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Session has expired")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Authorisation error")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal server error")]
        public virtual IActionResult ContactPhoneTypeList()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContactEmailType>));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204, default(Error));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Code\" : \"HE\",\n  \"Name\" : \"Home Email\"\n}, {\n  \"Code\" : \"HE\",\n  \"Name\" : \"Home Email\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ContactEmailType>>(exampleJson)
                        : default(List<ContactEmailType>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
