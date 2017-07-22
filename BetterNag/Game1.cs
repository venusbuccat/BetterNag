using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterNag
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // field - a variable/ a place in memory we use to store info 
        // like storing Texture2D objects
        // sprites for the teddy bears 
        Texture2D teddyBearSprite0;
        Texture2D teddyBearSprite1;
        Texture2D teddyBearSprite2;

        // draw rectangles for teddy bears 
        Rectangle drawRectangle0;
        Rectangle drawRectangle1;
        Rectangle drawRectangle2;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            // use texture2D objects that we declared earlier 

            teddyBearSprite0 = Content.Load<Texture2D>(@"graphics\teddybear0"); // wihtout the .xnb 
            teddyBearSprite1 = Content.Load<Texture2D>(@"graphics\teddybear1");
            teddyBearSprite2 = Content.Load<Texture2D>(@"graphics\teddybear2");

            //draw rectangles for each teddy bears 
            // we are overloading the constructor 
            // Rectangle(int x, int y, int width, int height)
            drawRectangle0 = new Rectangle(graphics.PreferredBackBufferWidth/4,
                graphics.PreferredBackBufferHeight/4, 
                teddyBearSprite0.Width, 
                teddyBearSprite0.Height);

            drawRectangle1 = new Rectangle(graphics.PreferredBackBufferWidth/2,
                graphics.PreferredBackBufferHeight/2, 
                teddyBearSprite1.Width, 
                teddyBearSprite1.Height);

            drawRectangle2 = new Rectangle(graphics.PreferredBackBufferWidth*3/4,
                graphics.PreferredBackBufferHeight*3/4,
                teddyBearSprite2.Width,
                teddyBearSprite2.Height);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(teddyBearSprite0, drawRectangle0, Color.White);
            spriteBatch.Draw(teddyBearSprite1, drawRectangle1, Color.White);
            spriteBatch.Draw(teddyBearSprite2, drawRectangle2, Color.White);

            spriteBatch.End(); 

            base.Draw(gameTime);
			
			//  entered a cooment for 2nd commit on tortoisegit
        }
    }
}
