CREATE PROCEDURE [dbo].[spAutoClick_Insert]
	@Quirk nvarchar(50),
	@MinStr int,
	@MinDur int,
	@MinStam int,
	@Items nvarchar(500),
	@Moves nvarchar(MAX),
	@Timing nvarchar(MAX)
AS
begin
	set nocount on;

	insert into dbo.AutoClick(Quirk, MinimumStrength, MinimumDurability, MinimumStamina, Items, Moves, Timing)
	values (@Quirk, @MinStr, @MinDur, @MinStam, @Items, @Moves, @Timing);

end
