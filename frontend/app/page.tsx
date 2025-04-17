import Filter from "./Components/Search and filter features/filter";
import Query from "./Components/Search and filter features/query";
import Search from "./Components/Search and filter features/search";
import styles from "./page.module.css";

// Call fetch function to get all Animal Data, Uses searchParams and slicing data array to create pagination functionality. Sets conditions for buttons to become disabled for Pagination Component.
export default async function Home({ searchParams }: { searchParams: Promise<{query: string | undefined; filter: string | undefined }>}) {
  
  // Renders feature components to main section.
  return (
    <main className={styles.main}>
      <section className={styles.mainTopContent}>
        <h2 className={styles.mainHeading}>Refresh you animal knowledge!</h2>
        <form className={styles.mainForm}>
          <Search/>
          <Filter/>
        </form>
      </section>
      
      <Query searchParams={searchParams}/>
    </main>
  );
}