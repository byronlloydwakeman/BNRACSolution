CREATE PROCEDURE [dbo].[spAutoClick_GetMin]
	@Quirk nvarchar(50),
	@MinStr int,
	@MinDur int,
	@MinStam int
AS
begin
	set nocount on;

	select Quirk, MinimumStrength, MinimumDurability, MinimumStamina, Items, Moves, Timing
	from dbo.AutoClick
	where MinimumStrength <= @MinStr 
	and MinimumDurability <= @MinDur
	and MinimumStamina <= @MinStam
	and Quirk = @Quirk;
end
