var pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad =
/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./BingAddressAutocomplete/index.ts");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./BingAddressAutocomplete/index.ts":
/*!******************************************!*\
  !*** ./BingAddressAutocomplete/index.ts ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval(" /// <reference path=\"types/MicrosoftMaps/Modules/Autosuggest.d.ts\" />\n\nObject.defineProperty(exports, \"__esModule\", {\n  value: true\n});\n\nvar BingAddressAutocomplete =\n/** @class */\nfunction () {\n  function BingAddressAutocomplete() {}\n\n  BingAddressAutocomplete.prototype.init = function (context, notifyOutputChanged, state, container) {\n    if (typeof context.parameters.bingapikey === \"undefined\" || typeof context.parameters.bingapikey.raw === \"undefined\") {\n      container.innerHTML = \"Please provide a valid bing api key\";\n      return;\n    }\n\n    this.notifyOutputChanged = notifyOutputChanged;\n    this.searchBox = document.createElement(\"input\");\n    this.searchBox.setAttribute(\"id\", \"searchBox\");\n    this.searchBox.className = \"addressAutocomplete\";\n    this.searchBox.addEventListener(\"mouseenter\", this.onMouseEnter.bind(this));\n    this.searchBox.addEventListener(\"mouseleave\", this.onMouseLeave.bind(this));\n\n    if (typeof context.parameters.value !== \"undefined\" && typeof context.parameters.value.raw !== \"undefined\" && context.parameters.value.raw != null) {\n      this.searchBox.setAttribute(\"value\", context.parameters.value.raw);\n    }\n\n    container.setAttribute(\"id\", \"searchBoxContainer\");\n    container.appendChild(this.searchBox);\n    var bingApiKey = context.parameters.bingapikey.raw;\n    var scriptUrl = \"https://www.bing.com/api/maps/mapcontrol?callback=loadAutoSuggest&key=\" + bingApiKey;\n    var scriptNode = document.createElement(\"script\");\n    scriptNode.setAttribute(\"type\", \"text/javascript\");\n    scriptNode.setAttribute(\"src\", scriptUrl); // scriptNode.setAttribute(\"async\", \"\");\n    // scriptNode.setAttribute(\"defer\", \"\");\n\n    document.head.appendChild(scriptNode);\n\n    var _this = this;\n\n    window.setTimeout(function () {\n      Microsoft.Maps.loadModule('Microsoft.Maps.AutoSuggest', {\n        callback: function callback() {\n          var options = {\n            maxResults: 5\n          };\n          var manager = new Microsoft.Maps.AutosuggestManager(options);\n          manager.attachAutosuggest('#searchBox', '#searchBoxContainer', function (suggestionResult) {\n            _this.street = suggestionResult.address.addressLine;\n            _this.city = suggestionResult.address.locality;\n            _this.county = suggestionResult.address.district;\n            _this.state = suggestionResult.address.adminDistrict;\n            _this.country = suggestionResult.address.countryRegion;\n            _this.zipcode = suggestionResult.address.postalCode;\n            _this.value = suggestionResult.formattedSuggestion || \"\";\n\n            _this.notifyOutputChanged();\n          });\n        },\n        errorCallback: function errorCallback() {\n          alert(\"Error with loading of module Microsoft.Maps.AutoSuggest.\");\n        }\n      });\n    }, 1000);\n  };\n\n  BingAddressAutocomplete.prototype.selectedSuggestion = function (suggestionResult) {\n    alert(suggestionResult.formattedSuggestion);\n    this.value = \"\";\n    this.street = \"\";\n    this.city = \"\";\n    this.county = \"\";\n    this.state = \"\";\n    this.country = \"\";\n    this.zipcode = \"\";\n    this.value = suggestionResult.formattedSuggestion || \"\";\n    this.notifyOutputChanged();\n  };\n\n  BingAddressAutocomplete.prototype.onMouseEnter = function () {\n    this.searchBox.className = \"addressAutocompleteFocused\";\n  };\n\n  BingAddressAutocomplete.prototype.onMouseLeave = function () {\n    this.searchBox.className = \"addressAutocomplete\";\n  };\n  /**\r\n   * Called when any value in the property bag has changed. This includes field values, data-sets, global values such as container height and width, offline status, control metadata values such as label, visible, etc.\r\n   * @param context The entire property bag available to control via Context Object; It contains values as set up by the customizer mapped to names defined in the manifest, as well as utility functions\r\n   */\n\n\n  BingAddressAutocomplete.prototype.updateView = function (context) {// Add code to update control view\n  };\n  /**\r\n   * It is called by the framework prior to a control receiving new data.\r\n   * @returns an object based on nomenclature defined in manifest, expecting object[s] for property marked as “bound” or “output”\r\n   */\n\n\n  BingAddressAutocomplete.prototype.getOutputs = function () {\n    return {\n      value: this.value,\n      street: this.street,\n      city: this.city,\n      county: this.county,\n      state: this.state,\n      country: this.country,\n      zipcode: this.zipcode\n    };\n  };\n  /**\r\n   * Called when the control is to be removed from the DOM tree. Controls should use this call for cleanup.\r\n   * i.e. cancelling any pending remote calls, removing listeners, etc.\r\n   */\n\n\n  BingAddressAutocomplete.prototype.destroy = function () {// Add code to cleanup control if necessary\n  };\n\n  return BingAddressAutocomplete;\n}();\n\nexports.BingAddressAutocomplete = BingAddressAutocomplete;\n\n//# sourceURL=webpack://pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad/./BingAddressAutocomplete/index.ts?");

/***/ })

/******/ });
if (window.ComponentFramework && window.ComponentFramework.registerControl) {
	ComponentFramework.registerControl('Primary.BingAddressAutocomplete', pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad.BingAddressAutocomplete);
} else {
	var Primary = Primary || {};
	Primary.BingAddressAutocomplete = pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad.BingAddressAutocomplete;
	pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad = undefined;
}