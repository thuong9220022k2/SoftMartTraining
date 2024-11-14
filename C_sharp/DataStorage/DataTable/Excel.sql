//1
SELECT flex_employee.name, flex_employee.email , flex_organization.* 
FROM flex_employee
JOIN flex_organization 
ON flex_employee.employee_id = flex_organization.parent_id 
JOIN flex_organization_employee
ON flex_employee.employee_id = flex_organization_employee.employee_id
WHERE flex_organization.deleted = null;

//2
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id IN (
    SELECT flex_organization_employee.employee_id 
    FROM flex_organization_employee 
    JOIN flex_organization 
    ON flex_organization_employee.organization_id = flex_organization.parent_id
); 
//3 
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id NOT IN (
    SELECT flex_organization_employee.employee_id 
    FROM flex_organization_employee 
    JOIN flex_organization 
    ON flex_organization_employee.organization_id = flex_organization.parent_id
); 
//4 
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id IN (
    SELECT flex_organization_employee.employee_id 
    FROM flex_organization_employee 
    JOIN flex_organization 
    ON flex_organization_employee.organization_id = flex_organization.parent_id
    WHERE flex_organization.code = 'PB_001'
);
//5
SELECT flex_organization.name
FROM flex_organization
WHERE flex_organization.code = 'NV_001';
//6
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id IN (
    SELECT flex_organization_employee.employee_id 
    FROM flex_organization_employee
    GROUP BY flex_organization_employee.employee_id 
    HAVING COUNT(flex_organization_employee.organization_id) > 1
)
//7
SELECT flex_organization.name 
FROM flex_organization 
WHERE flex_organization.parent_id IN (
SELECT flex_organization_employee.organization_id 
FROM flex_organization_employee
GROUP BY flex_organization_employee.organization_id 
HAVING COUNT(flex_organization_employee.employee_id) > 10
);
//8
SELECT name
FROM (
SELECT flex_employee.name,flex_organization_employee.organization_id, flex_employee.created_dtg,
ROW_NUMBER() OVER (PARTITION BY flex_organization_employee.organization_id ORDER BY flex_employee.created_dtg DESC) AS od
FROM flex_employee
JOIN flex_organization_employee
ON flex_organization_employee.employee_id = flex_employee.employee_id
)
WHERE od = 1;
// same create_dtg row_number ? 
//9
SELECT flex_organization.parent_id 
FROM flex_organization
WHERE flex_organization.organization_id IN (
SELECT flex_organization_employee.organization_id 
FROM flex_organization_employee
GROUP BY flex_organization_employee.organization_id
HAVING COUNT(1) > 0
);
//10
UPDATE flex_organization 
SET flex_organization.name = flex_organization.name || '_SV' 
WHERE flex_organization.organization_id IN (
SELECT flex_organization_employee.organization_id
FROM flex_organization_employee
WHERE flex_organization_employee.employee_id IN (
SELECT flex_employee.employee_id
FROM flex_employee
WHERE flex_employee.user_name = 'NV_001'
)
);

