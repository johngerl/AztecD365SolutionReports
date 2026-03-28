# D365 to Salesforce Data Type Compatibility Matrix

This file is read by Step 7 (`generate_d365_sf_suggestions.py`) at runtime to determine data type compatibility during field matching. The first SF type listed per row is the **preferred** type for rule-based name generation.

Edit this file to add, remove, or reorder compatible types without changing code.

| D365 Type           | Compatible SF Types                 |
| ------------------- | ----------------------------------- |
| nvarchar            | string, phone, email, url, textarea |
| ntext               | textarea, string                    |
| int                 | int, double                         |
| decimal             | double, currency                    |
| float               | double                              |
| money               | currency, double                    |
| bit                 | boolean                             |
| datetime            | datetime, date                      |
| lookup              | reference, id                       |
| customer            | reference, id                       |
| owner               | reference, id                       |
| picklist            | picklist, string                    |
| multiselectpicklist | multipicklist, string               |
| state               | picklist, string                    |
| status              | picklist, string                    |
| uniqueidentifier    | string, id                          |
| primarykey          | string, id                          |
| entityname          | string                              |
| partylist           | reference                           |
| image               | base64, string                      |
| bigint              | double, int                         |

---

## Data Type Reference

| Data Type | Platform | Description | Precision | Min | Max |
| --- | --- | --- | --- | --- | --- |
| address | SF | Compound address field (street, city, state, postal code, country) | N/A | N/A | N/A |
| base64 | SF | Base64-encoded binary data | N/A | N/A | N/A |
| bigint | D365 | 64-bit integer | N/A | −9,223,372,036,854,775,808 | 9,223,372,036,854,775,807 |
| bit | D365 | Boolean value (0 or 1) | N/A | 0 | 1 |
| boolean | SF | Checkbox (true/false) | N/A | false | true |
| combobox | SF | Editable picklist (legacy/deprecated) | N/A | N/A | N/A |
| currency | SF | Currency amount with org-level or field-level decimal scale | Up to 18 digits | N/A | N/A |
| customer | D365 | Polymorphic lookup to Account or Contact | N/A | N/A | N/A |
| date | SF | Date only (no time component) | Day | 1700-01-01 | 4000-12-31 |
| datetime | Both | Date and time value | D365: minutes; SF: milliseconds | D365: 1753-01-01; SF: 1700-01-01 | D365: 9999-12-31; SF: 4000-12-31 |
| decimal | D365 | Fixed-point decimal number | 0–10 decimal places | −100,000,000,000 | 100,000,000,000 |
| double | SF | Floating-point number | Up to 18 digits total (length + scale) | Field-defined | Field-defined |
| email | SF | Email address string | N/A | N/A | 254 chars |
| entityname | D365 | Entity logical name string | N/A | N/A | N/A |
| float | D365 | Floating-point number | 0–5 decimal places | −100,000,000,000 | 100,000,000,000 |
| id | SF | 18-character Salesforce record identifier | N/A | N/A | 18 chars |
| image | D365 | Binary image data | N/A | N/A | N/A |
| int | Both | 32-bit integer | N/A | −2,147,483,648 | 2,147,483,647 |
| lookup | D365 | Foreign key reference to another entity | N/A | N/A | N/A |
| money | D365 | Currency value with precision settings | 0–4 decimal places | −922,337,203,685,477.5808 | 922,337,203,685,477.5807 |
| multipicklist | SF | Multi-select picklist (semicolon-delimited) | N/A | N/A | N/A |
| multiselectpicklist | D365 | Multi-select option set | N/A | N/A | N/A |
| ntext | D365 | Multi-line text (memo field) | N/A | N/A | 1,048,576 chars |
| nvarchar | D365 | Single-line text string | N/A | N/A | 4,000 chars |
| owner | D365 | Polymorphic lookup to User or Team | N/A | N/A | N/A |
| partylist | D365 | Activity party list (multi-entity reference) | N/A | N/A | N/A |
| percent | SF | Percentage value | Up to 18 digits total (length + scale) | Field-defined | Field-defined |
| phone | SF | Phone number string | N/A | N/A | 40 chars |
| picklist | Both | Single-select option set (D365) / picklist (SF) | N/A | N/A | N/A |
| primarykey | D365 | GUID primary key identifier | N/A | N/A | N/A |
| reference | SF | Foreign key lookup to another object | N/A | N/A | N/A |
| state | D365 | Entity state code (e.g., Active/Inactive) | N/A | N/A | N/A |
| status | D365 | Entity status reason code (child of state) | N/A | N/A | N/A |
| string | SF | Single-line text string | N/A | N/A | 255 chars (default) |
| textarea | SF | Multi-line text (long text area up to 131,072 chars; rich text up to 131,072 chars) | N/A | N/A | 131,072 chars |
| time | SF | Time of day (no date component) | Milliseconds | 00:00:00.000Z | 23:59:59.999Z |
| uniqueidentifier | D365 | GUID (globally unique identifier) | N/A | N/A | N/A |
| url | SF | URL string | N/A | N/A | 255 chars |
