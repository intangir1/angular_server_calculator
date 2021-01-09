using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcServerTrain
{
    [Route("api")]
    [ApiController]
    public class MathApiController : ControllerBase
    {
        private readonly IMathRepository mathRepository;

        public MathApiController (IMathRepository _mathRepository)
        {
            mathRepository = _mathRepository;
        }

        [HttpGet("plus/{num1}/{num2}")]
        public IActionResult Plus(int num1, int num2)
        {
            try
            {
                int result = mathRepository.Plus(num1, num2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Errors errors = ErrorsHelper.GetErrors(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }


        [HttpPost("plus")]
        public IActionResult Plus(Math_pair math_pair)
        {
            try
            {
                int result = mathRepository.Plus(math_pair.num1, math_pair.num2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Errors errors = ErrorsHelper.GetErrors(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }


        [HttpGet("minus/{num1}/{num2}")]
        public IActionResult Minus(int num1, int num2)
        {
            try
            {
                int result = mathRepository.Minus(num1, num2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Errors errors = ErrorsHelper.GetErrors(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }


        [HttpGet("mult/{num1}/{num2}")]
        public IActionResult Mult(int num1, int num2)
        {
            try
            {
                int result = mathRepository.Mult(num1, num2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Errors errors = ErrorsHelper.GetErrors(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }


        [HttpGet("div/{num1}/{num2}")]
        public IActionResult Div(int num1, int num2)
        {
            try
            {
                double result = mathRepository.Div(num1, num2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Errors errors = ErrorsHelper.GetErrors(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }

    }
}