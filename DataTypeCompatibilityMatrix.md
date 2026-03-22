# D365 to Salesforce Data Type Compatibility Matrix

This file is read by Step 7 (`generate_d365_sf_suggestions.py`) at runtime to determine data type compatibility during field matching. The first SF type listed per row is the **preferred** type for rule-based name generation.

Edit this file to add, remove, or reorder compatible types without changing code.

| D365 Type | Compatible SF Types |
|---|---|
| nvarchar | string, phone, email, url, textarea |
| ntext | textarea, string |
| int | int, double |
| decimal | double, currency |
| float | double |
| money | currency, double |
| bit | boolean |
| datetime | datetime, date |
| lookup | reference, id |
| customer | reference, id |
| owner | reference, id |
| picklist | picklist, string |
| multiselectpicklist | multipicklist, string |
| state | picklist, string |
| status | picklist, string |
| uniqueidentifier | id, string |
| primarykey | id |
| entityname | string |
| partylist | reference |
| image | base64, string |
| bigint | double, int |
