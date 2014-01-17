using System;
using System.Collections.Generic;
using TinymoeDotNet;

namespace TinymoeProgramNamespace
{
	public class TinymoeProgram : TinymoeOperations
	{
		public readonly TinymoeObject standard_library__breaking_repeating = new TinymoeString("standard_library__breaking_repeating");

		public readonly TinymoeObject standard_library__continuing_repeating = new TinymoeString("standard_library__continuing_repeating");

		public readonly TinymoeObject standard_library__raising_exception = new TinymoeString("standard_library__raising_exception");

		public readonly TinymoeObject standard_library__exiting_program = new TinymoeString("standard_library__exiting_program");

		public readonly TinymoeObject standard_library__exiting_block = new TinymoeString("standard_library__exiting_block");

		public class standard_library__continuation_trap : TinymoeObject
		{
			public standard_library__continuation_trap()
			{
				SetField("continuation", null);
				SetField("previous_trap", null);
			}
		}

		public class standard_library__continuation_state : TinymoeObject
		{
			public standard_library__continuation_state()
			{
				SetField("flag", null);
				SetField("argument", null);
				SetField("continuation", null);
				SetField("trap", null);
			}
		}

		public void standard_library__reset_continuation_state__expression_to__expression(TinymoeObject _state, TinymoeObject state, TinymoeObject flag, TinymoeObject _continuation)
		{
		}

		public void standard_library__call__expression(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__trap__expression(TinymoeObject state, TinymoeObject value, TinymoeObject continuation)
		{
		}

		public void standard_library__fall_into_the_previous_trap(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__break(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__continue(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__raise__expression(TinymoeObject state, TinymoeObject exception, TinymoeObject continuation)
		{
		}

		public void standard_library__exit_program(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__exit_block__expression(TinymoeObject state, TinymoeObject handle, TinymoeObject continuation)
		{
		}

		public void standard_library__repeat(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_while__expression(TinymoeObject _state, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_from__expression_to__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject lower_bound, TinymoeObject upper_bound, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_in__expression_array_(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void standard_library__if__expression(TinymoeObject _state, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__else_if__expression(TinymoeObject _state, TinymoeObject signal, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__else(TinymoeObject _state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__try(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__catch__argument(TinymoeObject state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__finally(TinymoeObject state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__named_block__argument(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__add__expression_to_assignable(TinymoeObject _state, TinymoeObject value, TinymoeObject _read_variable, TinymoeObject _write_variable, TinymoeObject _continuation)
		{
		}

		public void standard_library__substract__expression_from_assignable(TinymoeObject _state, TinymoeObject value, TinymoeObject _read_variable, TinymoeObject _write_variable, TinymoeObject _continuation)
		{
		}

		public void standard_library__boolean_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__integer_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__floating_point_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__string_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void hello_world__print__expression(TinymoeObject _state, TinymoeObject message, TinymoeObject _continuation)
		{
		}

		public void hello_world__sum_from__expression_to__primitive(TinymoeObject _state, TinymoeObject first_number, TinymoeObject last_number, TinymoeObject _continuation)
		{
		}

		public void hello_world__main(TinymoeObject _state, TinymoeObject _continuation)
		{
		}

		public void _dispatch_fail__standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void TinymoeArray___dispatch__standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch__standard_library__repeat_with__argument_in__expression_x2(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public TinymoeProgram()
		{
			TinymoeObject.SetExtension(
				typeof(TinymoeArray),
				"_dispatch__standard_library__repeat_with__argument_in__expression",
				new TinymoeFunction(__args__ => TinymoeArray___dispatch__standard_library__repeat_with__argument_in__expression(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch__standard_library__repeat_with__argument_in__expression_x2",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch__standard_library__repeat_with__argument_in__expression_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
		}

		static void Main(string[] args)
		{
			var program = new TinymoeProgram();
			var continuation = new TinymoeFunction((TinymoeObject[] arguments) =>
			{
			});
			var trap = new TinymoeProgram.standard_library__continuation_trap();
			trap.SetField("continuation", continuation);
			var state = new TinymoeProgram.standard_library__continuation_state();
			state.SetField("trap", trap);
			program.hello_world__main(state, continuation);
		}
	}
}
