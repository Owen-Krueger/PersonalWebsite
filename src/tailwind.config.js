/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,cshtml,html}"],
  theme: {
    extend: {},
  },
  plugins: [],
  safelist: [
    {
      pattern: /bg-(red|green|blue|sky|purple)-500/
    },
    {
      pattern: /text-(red|green|blue|sky|purple)-500/
    }
  ]
}