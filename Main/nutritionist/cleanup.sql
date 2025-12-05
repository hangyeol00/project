-- nutritionist schema cleanup (drop existing tables in dependency-safe order)
SET ECHO ON;

DECLARE
    PROCEDURE drop_table(p_name VARCHAR2) IS
    BEGIN
        EXECUTE IMMEDIATE 'DROP TABLE ' || p_name || ' CASCADE CONSTRAINTS';
    EXCEPTION
        WHEN OTHERS THEN
            IF SQLCODE != -942 THEN
                RAISE;
            END IF;
    END;
BEGIN
    drop_table('PurchaseRequest');
    drop_table('RawContract');
    drop_table('Vendor');
    drop_table('AltReview');
    drop_table('MealReviewItem');
    drop_table('MealReview');
    drop_table('AltAssign');
    drop_table('ConsumerAllergy');
    drop_table('Consumer');
    drop_table('MealComp');
    drop_table('Meal');
    drop_table('MealPlan');
    drop_table('MenuComp');
    drop_table('MenuTagMap');
    drop_table('MenuTag');
    drop_table('FinalMenu');
    drop_table('IngredientComp');
    drop_table('Ingredient');
    drop_table('RawAllergy');
    drop_table('RawNutrient');
    drop_table('Allergy');
    drop_table('Nutrient');
    drop_table('RawMaterial');
    drop_table('RawCategory');
    drop_table('AppUser');
END;
/

COMMIT;
